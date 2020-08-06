using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MAD.API.Procore
{
    public class OAuthTokenExchange
    {
        public class OAuthTokenResponse
        {
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }

            [JsonProperty("expires_in")]
            public long? ExpiresInSeconds { get; set; }

            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }
        }

        private Uri GetBaseAddress(bool isSandbox)
        {
            if (isSandbox)
                return new Uri("https://login-sandbox.procore.com/oauth/");
            else
                return new Uri("https://login.procore.com/oauth/");
        }

        public async Task<OAuthTokenResponse> ExchangeRefreshToken(ProcoreApiClientOptions options, HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.PostAsync(new Uri(this.GetBaseAddress(options.IsSandbox), "token"), new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "grant_type", "refresh_token" },
                { "refresh_token", options.RefreshToken }
            }));

            string accessTokenJson = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ProcoreApiException(response.ReasonPhrase, accessTokenJson);
            }

            OAuthTokenResponse tokenResponse = JsonConvert.DeserializeObject<OAuthTokenResponse>(accessTokenJson);

            return tokenResponse;
        }
    }
}
