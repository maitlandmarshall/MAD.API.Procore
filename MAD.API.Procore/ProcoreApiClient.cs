using MAD.API.Procore.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

        internal ProcoreApiClient(HttpClient httpClient, ProcoreApiClientOptions options, ProcoreRequestUriQuerySegmentFactory querySegmentFactory, OAuthTokenExchange tokenExchange)
        {
            this.httpClient = httpClient;
            this.options = options;
            this.querySegmentFactory = querySegmentFactory;
            this.tokenExchange = tokenExchange;
        }

        public event EventHandler<ApiClientOptionsChangedEventArgs> OptionsChanged;

        public async Task<ProcoreResponse<TModel>> GetResponseAsync<TModel>(ProcoreRequest<TModel> request)
        {
            IEnumerable<string> queryParams = this.querySegmentFactory.Create(request);
            string query = $"{request.Resource}?{string.Join("&", queryParams)}";

            HttpResponseMessage httpResponse = await this.httpClient.GetAsync(query);

            using Stream stream = await httpResponse.Content.ReadAsStreamAsync();
            using StreamReader sr = new StreamReader(stream);
            using JsonTextReader jr = new JsonTextReader(sr);

            JsonSerializer jsonSerializer = new JsonSerializer();

            if (!httpResponse.IsSuccessStatusCode)
            {
                string error = await sr.ReadToEndAsync();

                // Has the access token expired? Use the refresh token to get a new one
                if (httpResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized
                    && error.Contains("refresh token")
                    && !string.IsNullOrEmpty(this.options.RefreshToken))
                {
                    await this.UseRefreshToken();

                    return await this.GetResponseAsync<TModel>(request);
                }

                // If there are too many requests, wait until the quota yields
                else if (httpResponse.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    int unixTimeUntilRefresh = int.Parse(httpResponse.Headers.GetValues("X-Rate-Limit-Reset".ToLower()).First());
                    DateTimeOffset refreshDate = DateTimeOffset.FromUnixTimeSeconds(unixTimeUntilRefresh);
                    DateTimeOffset currentDate = DateTimeOffset.UtcNow;

                    TimeSpan waitSeconds = refreshDate - currentDate;
                    await Task.Delay(waitSeconds);

                    return await this.GetResponseAsync<TModel>(request);
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

            TModel result = jsonSerializer.Deserialize<TModel>(jr);

            ProcoreResponse<TModel> procoreResponse = new ProcoreResponse<TModel>(this)
            {
                Result = result,
                Request = request,
                IsLastPage = request.Page == lastPage
            };

            return procoreResponse;
        }

        private async Task UseRefreshToken()
        {
            bool isRefreshing = semaphore.CurrentCount == 0;
            await semaphore.WaitAsync();

            try
            {
                if (isRefreshing)
                    return;

                OAuthTokenExchange.OAuthTokenResponse newToken = await this.tokenExchange.ExchangeRefreshToken(this.options, this.httpClient);

                this.options.AccessToken = newToken.AccessToken;
                this.options.RefreshToken = newToken.RefreshToken;

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
