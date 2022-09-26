
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MAD.API.Procore
{
    public class DefaultProcoreApiClientFactory
    {
        private Uri GetBaseAddress(bool isSandbox)
        {
            if (isSandbox)
                return new Uri("https://sandbox.procore.com");
            else
                return new Uri("https://api.procore.com");
        }

        public ProcoreApiClient Create(ProcoreApiClientOptions options)
        {
            var httpClient = this.CreateHttpClient(options);

            return new ProcoreApiClient(
                httpClient: httpClient,
                options: options);
        }

        public HttpClient CreateHttpClient(ProcoreApiClientOptions options)
        {
            var httpClient = new HttpClient(
                handler: new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.None,
                });

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", options.AccessToken);
            httpClient.BaseAddress = GetBaseAddress(options.IsSandbox);

            return httpClient;
        }
    }
}
