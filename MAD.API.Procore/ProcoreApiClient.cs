using MAD.API.Procore.Requests;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MAD.API.Procore
{
    public class ProcoreApiClient
    {
        private readonly HttpClient httpClient;
        private readonly ProcoreApiClientOptions options;
        private readonly ProcoreRequestUriQuerySegmentFactory querySegmentFactory;

        internal ProcoreApiClient(HttpClient httpClient, ProcoreApiClientOptions options, ProcoreRequestUriQuerySegmentFactory querySegmentFactory)
        {
            this.httpClient = httpClient;
            this.options = options;
            this.querySegmentFactory = querySegmentFactory;
        }

        public async Task<ProcoreResponse<TModel>> GetResponseAsync<TModel>(ProcoreRequest<TModel> request)
        {
            IEnumerable<string> queryParams = this.querySegmentFactory.Create(request);
            string query = $"{request.Resource}?{string.Join("&", queryParams)}";

            HttpResponseMessage httpResponse = await this.httpClient.GetAsync(query);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new HttpRequestException(httpResponse.ReasonPhrase);
            }

            using Stream stream = await httpResponse.Content.ReadAsStreamAsync();
            using StreamReader sr = new StreamReader(stream);
            using JsonTextReader jr = new JsonTextReader(sr);

            JsonSerializer jsonSerializer = new JsonSerializer();
            IEnumerable<TModel> items = jsonSerializer.Deserialize<IEnumerable<TModel>>(jr);

            ProcoreResponse<TModel> procoreResponse = new ProcoreResponse<TModel>(this)
            {
                Items = items,
                Request = request
            };

            return procoreResponse;
        }
    }
}
