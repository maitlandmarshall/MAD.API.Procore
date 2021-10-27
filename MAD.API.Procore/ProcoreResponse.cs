
using System.Threading.Tasks;

namespace MAD.API.Procore
{
    public class ProcoreResponse<TModel>
    {
        private readonly ProcoreApiClient apiClient;

        internal ProcoreResponse(ProcoreApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public ProcoreRequest<TModel> Request { get; internal set; }
        public TModel Result { get; internal set; }
        internal bool IsLastPage { get; set; }

        public async Task<ProcoreResponse<TModel>> GetNextPageAsync()
        {
            if (IsLastPage)
                return null;

            Request.Page++;

            return await apiClient.GetResponseAsync(Request);
        }
    }
}
