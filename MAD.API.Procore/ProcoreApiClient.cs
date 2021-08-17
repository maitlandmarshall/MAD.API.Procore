using MAD.API.Procore.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

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
            await this.Authenticate();

            var queryParams = this.querySegmentFactory.Create(request);
            var query = $"{request.Resource.TrimStart('/')}?{string.Join("&", queryParams)}";

            HttpResponseMessage httpResponse;

            if (request.HttpMethod == HttpMethod.Get)
            {
                httpResponse = await this.httpClient.GetAsync(query);
            }
            else if (request.HttpMethod == HttpMethod.Post)
            {
                httpResponse = await this.httpClient.PostAsync(query, new StringContent(request.Body, Encoding.UTF8, "application/json"));
            }
            else if (request.HttpMethod == HttpMethod.Patch)
            {
                httpResponse = await this.httpClient.PatchAsync(query, new StringContent(request.Body, Encoding.UTF8, "application/json"));
            }
            else
            {
                throw new NotImplementedException();
            }

            return await this.ReadResponse<TResponse>(request, httpResponse);
        }

        private async Task<ProcoreResponse<TResponse>> ReadResponse<TResponse>(ProcoreRequest<TResponse> request, HttpResponseMessage httpResponse)
        {
            using Stream stream = await httpResponse.Content.ReadAsStreamAsync();
            using StreamReader sr = new StreamReader(stream);
            using JsonTextReader jr = new JsonTextReader(sr);

            JsonSerializer jsonSerializer = new JsonSerializer();

            if (!httpResponse.IsSuccessStatusCode)
            {
                string error = await sr.ReadToEndAsync();

                if (httpResponse.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    int unixTimeUntilRefresh = int.Parse(httpResponse.Headers.GetValues("X-Rate-Limit-Reset".ToLower()).First());
                    DateTimeOffset refreshDate = DateTimeOffset.FromUnixTimeSeconds(unixTimeUntilRefresh);
                    DateTimeOffset currentDate = DateTimeOffset.UtcNow;

                    TimeSpan timeDifference = refreshDate - currentDate;
                    int millisecondsToWait = (int)Math.Max(timeDifference.TotalMilliseconds, 0);

                    await Task.Delay(millisecondsToWait);

                    return await this.GetResponseAsync<TResponse>(request);
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

            ProcoreResponse<TResponse> procoreResponse = new ProcoreResponse<TResponse>(this)
            {
                Result = result,
                Request = request,
                IsLastPage = request.Page == lastPage
            };

            return procoreResponse;
        }

        private async Task Authenticate()
        {
            if (!string.IsNullOrWhiteSpace(this.options.AccessToken))
            {
                if (this.currentOAuth?.CreatedAt.HasValue == true && this.currentOAuth?.ExpiresInSeconds.HasValue == true)
                {
                    var oauthExpiresIn = this.currentOAuth.CreatedAt.Value.AddSeconds(this.currentOAuth.ExpiresInSeconds.Value).ToLocalTime();
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
            
            if (!string.IsNullOrWhiteSpace(this.options.ClientId) && !string.IsNullOrWhiteSpace(this.options.ClientSecret))
            {
                await this.GetAccessToken();
            }
            else if (!string.IsNullOrWhiteSpace(this.options.RefreshToken))
            {
                await this.GetAccessToken();
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
                
                if (!string.IsNullOrWhiteSpace(this.options.RefreshToken))
                {
                    authToken = await this.tokenExchange.ExchangeRefreshToken(this.options.RefreshToken, this.httpClient, this.options.IsSandbox);
                }
                else
                {
                    authToken = await this.tokenExchange.GetAccessToken(this.options.ClientId, this.options.ClientSecret, this.httpClient, this.options.IsSandbox);
                }

                this.currentOAuth = authToken;

                this.options.AccessToken = authToken.AccessToken;
                this.options.RefreshToken = authToken.RefreshToken;

                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.options.AccessToken);
                this.OptionsChanged?.Invoke(this, new ApiClientOptionsChangedEventArgs(this.options));
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
