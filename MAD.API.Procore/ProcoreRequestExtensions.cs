using System.Threading.Tasks;

namespace MAD.API.Procore
{
    public static class ProcoreRequestExtensions
    {
        public static Task<ProcoreResponse<TModel>> GetResponse<TModel>(this ProcoreRequest<TModel> request, ProcoreApiClient client)
        {
            return client.GetResponseAsync<TModel>(request);
        }
    }
}
