using System.Collections.Generic;

namespace MAD.API.Procore.Requests
{
    public abstract class ProcoreRequest
    {
        public abstract string Resource { get; }

        [RequestParameter("per_page")]
        public int PerPage { get; set; } = Constants.MaxResultsPerPage;

        [RequestParameter("page")]
        public int Page { get; set; } = 1;
    }

    public abstract class ProcoreRequest<TResponse> : ProcoreRequest
    {
        
    }
}
