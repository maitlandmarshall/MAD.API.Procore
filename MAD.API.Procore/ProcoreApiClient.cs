
using MAD.API.Procore.Endpoints.PunchItems.Models;
using MAD.API.Procore.Endpoints.RFIs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MAD.API.Procore
{
    public class ProcoreApiClient
    {
        private readonly HttpClient httpClient;
        private readonly ProcoreApiClientOptions options;
        private readonly ProcoreRequestUriQuerySegmentFactory querySegmentFactory;
        private readonly OAuthTokenExchange tokenExchange;
        private static readonly SemaphoreSlim semaphore = new SemaphoreSlim(1);
        private OAuthTokenExchange.OAuthTokenResponse currentOAuth;

        internal ProcoreApiClient(HttpClient httpClient, ProcoreApiClientOptions options, ProcoreRequestUriQuerySegmentFactory querySegmentFactory, OAuthTokenExchange tokenExchange)
        {
            this.httpClient = httpClient;
            this.options = options;
            this.querySegmentFactory = querySegmentFactory;
            this.tokenExchange = tokenExchange;
        }

        public event EventHandler<ApiClientOptionsChangedEventArgs> OptionsChanged;        

        public async Task<ProcoreResponse<TResponse>> GetResponseAsync<TResponse>(ProcoreRequest<TResponse> request)
        {
            await Authenticate();

            var queryParams = querySegmentFactory.Create(request);
            var query = $"{request.Resource.TrimStart('/')}?{string.Join("&", queryParams)}";

            HttpResponseMessage httpResponse;

            if (request.HttpMethod == HttpMethod.Get)
            {
                httpResponse = await httpClient.GetAsync(query);
            }
            else if (request.HttpMethod == HttpMethod.Post)
            {
                httpResponse = await httpClient.PostAsync(query, new StringContent(request.Body, Encoding.UTF8, "application/json"));
            }
            else if (request.HttpMethod == HttpMethod.Patch)
            {
                httpResponse = await httpClient.PatchAsync(query, new StringContent(request.Body, Encoding.UTF8, "application/json"));
            }
            else
            {
                throw new NotImplementedException();
            }

            return await ReadResponse<TResponse>(request, httpResponse);
        }

        private async Task<ProcoreResponse<TResponse>> ReadResponse<TResponse>(ProcoreRequest<TResponse> request, HttpResponseMessage httpResponse)
        {
            using Stream stream = await httpResponse.Content.ReadAsStreamAsync();
            using StreamReader sr = new StreamReader(stream);
            using JsonTextReader jr = new JsonTextReader(sr);

            JsonSerializer jsonSerializer = JsonSerializer.CreateDefault(new JsonSerializerSettings
            {
                Error = (sender, args) =>
                {
                    // The Procore API returns a different value than the schema specifies, so just ignore the error
                    if (args.CurrentObject?.GetType() == typeof(ListRFIsRequestResultQuestion)
                        && args.ErrorContext.Path.EndsWith("errors"))
                    {
                        args.ErrorContext.Handled = true;
                    }
                }
            });

            if (!httpResponse.IsSuccessStatusCode)
            {
                string error = await sr.ReadToEndAsync();

                if (httpResponse.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    int unixTimeUntilRefresh = int.Parse(httpResponse.Headers.GetValues("X-Rate-Limit-Reset".ToLower()).First());
                    var refreshDate = DateTimeOffset.FromUnixTimeSeconds(unixTimeUntilRefresh);

                    throw new ProcoreRateLimitException(refreshDate);
                }

                throw new ProcoreApiException(httpResponse.ReasonPhrase, error, httpResponse.StatusCode);
            }

            // Extract the last page from the response headers
            int lastPage = 1;

            if (httpResponse.Headers.TryGetValues("total", out IEnumerable<string> totalValues))
            {
                string totalString = totalValues.First();
                int total = int.Parse(totalString);
                float totalPages = (float)total / Constants.MaxResultsPerPage;

                lastPage = Math.Max((int)Math.Ceiling(totalPages), 1);
            }

            TResponse result = jsonSerializer.Deserialize<TResponse>(jr);

            var procoreResponse = new ProcoreResponse<TResponse>(this)
            {
                Result = result,
                Request = request
            };

            if (request is ProcorePaginatedRequest<TResponse> paginatedRequest)
            {
                procoreResponse.IsLastPage = paginatedRequest.Page == lastPage;
            }

            return procoreResponse;
        }

        private async Task Authenticate()
        {
            if (!string.IsNullOrWhiteSpace(options.AccessToken))
            {
                if (currentOAuth?.CreatedAt.HasValue == true && currentOAuth?.ExpiresInSeconds.HasValue == true)
                {
                    var oauthExpiresIn = currentOAuth.CreatedAt.Value.AddSeconds(currentOAuth.ExpiresInSeconds.Value).ToLocalTime();
                    var now = DateTime.Now;

                    // If oauth expires in the future, do nothing
                    if (oauthExpiresIn >= now)
                        return;
                }
                else
                {
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(options.ClientId) && !string.IsNullOrWhiteSpace(options.ClientSecret))
            {
                await GetAccessToken();
            }
            else if (!string.IsNullOrWhiteSpace(options.RefreshToken))
            {
                await GetAccessToken();
            }
            else
            {
                throw new ProcoreClientException("ClientId and ClientSecret or a Refresh Token must be provided.");
            }
        }

        private async Task GetAccessToken()
        {
            bool isRefreshing = semaphore.CurrentCount == 0;
            await semaphore.WaitAsync();

            try
            {
                if (isRefreshing)
                    return;

                OAuthTokenExchange.OAuthTokenResponse authToken;

                if (!string.IsNullOrWhiteSpace(options.RefreshToken))
                {
                    authToken = await tokenExchange.ExchangeRefreshToken(options.RefreshToken, httpClient, options.IsSandbox);
                }
                else
                {
                    authToken = await tokenExchange.GetAccessToken(options.ClientId, options.ClientSecret, httpClient, options.IsSandbox);
                }

                currentOAuth = authToken;

                options.AccessToken = authToken.AccessToken;
                options.RefreshToken = authToken.RefreshToken;

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", options.AccessToken);
                OptionsChanged?.Invoke(this, new ApiClientOptionsChangedEventArgs(options));
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
