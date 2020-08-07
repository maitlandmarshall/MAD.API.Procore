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

                if (httpResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized
                    && error.Contains("refresh token")
                    && !string.IsNullOrEmpty(this.options.RefreshToken))
                {
                    await this.UseRefreshToken();

                    return await this.GetResponseAsync<TModel>(request);
                }
                else if (httpResponse.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    int unixTimeUntilRefresh = int.Parse(httpResponse.Headers.GetValues("X-Rate-Limit-Reset".ToLower()).First());
                    var refreshDate = DateTimeOffset.FromUnixTimeSeconds(unixTimeUntilRefresh);
                    var currentDate = DateTimeOffset.UtcNow;

                    var waitSeconds = refreshDate - currentDate;
                    await Task.Delay(waitSeconds);

                    return await this.GetResponseAsync<TModel>(request);
                }

                throw new ProcoreApiException(httpResponse.ReasonPhrase, error, httpResponse.StatusCode);
            }

            TModel result = jsonSerializer.Deserialize<TModel>(jr);

            ProcoreResponse<TModel> procoreResponse = new ProcoreResponse<TModel>(this)
            {
                Result = result,
                Request = request
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
