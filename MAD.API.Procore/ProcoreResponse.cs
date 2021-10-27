
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
        public bool IsLastPage { get; set; }
    }
}
