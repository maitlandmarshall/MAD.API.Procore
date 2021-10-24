using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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

            [JsonProperty("created_at")]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime? CreatedAt { get; set; }
        }

        private Uri GetBaseAddress(bool isSandbox)
        {
            if (isSandbox)
                return new Uri("https://login-sandbox.procore.com/oauth/");
            else
                return new Uri("https://login.procore.com/oauth/");
        }

        public async Task<OAuthTokenResponse> ExchangeRefreshToken(string refreshToken, HttpClient httpClient, bool isSandbox = false)
        {
            return await PerformOAuthToken(new Dictionary<string, string>
            {
                { "grant_type", "refresh_token" },
                { "refresh_token", refreshToken }
            }, httpClient, isSandbox);
        }

        public async Task<OAuthTokenResponse> GetAccessToken(string clientId, string clientSecret, HttpClient httpClient, bool isSandbox = false)
        {
            return await PerformOAuthToken(new Dictionary<string, string>
            {
                { "grant_type", "client_credentials" },
                { "client_id", clientId },
                { "client_secret", clientSecret },
            }, httpClient, isSandbox);
        }

        private async Task<OAuthTokenResponse> PerformOAuthToken(IDictionary<string, string> postBody, HttpClient httpClient, bool isSandbox = false)
        {
            HttpResponseMessage response = await httpClient.PostAsync(new Uri(GetBaseAddress(isSandbox), "token"), new FormUrlEncodedContent(postBody));

            string accessTokenJson = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ProcoreApiException(response.ReasonPhrase, accessTokenJson, response.StatusCode);
            }

            OAuthTokenResponse tokenResponse = JsonConvert.DeserializeObject<OAuthTokenResponse>(accessTokenJson);

            return tokenResponse;
        }
    }
}
