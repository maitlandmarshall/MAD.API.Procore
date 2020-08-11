using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MAD.API.Procore.Requests
{
    public static class ProcoreRequestExtensions
    {
        public static Task<ProcoreResponse<TModel>> GetResponse<TModel>(this ProcoreRequest<TModel> request, ProcoreApiClient client)
        {
            return client.GetResponseAsync<TModel>(request);
        }
    }
}
