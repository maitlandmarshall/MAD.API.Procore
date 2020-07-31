using MAD.API.Procore.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MAD.API.Procore
{
    public class ProcoreResponse <TModel>
    {
        private readonly ProcoreApiClient apiClient;

        internal ProcoreResponse(ProcoreApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public ProcoreRequest<TModel> Request { get; internal set; }
        public TModel Result { get; internal set; }

        public Task<ProcoreResponse<TModel>> GetNextPageAsync()
        {
            this.Request.Page++;

            return this.apiClient.GetResponseAsync(this.Request);
        }
    }
}
