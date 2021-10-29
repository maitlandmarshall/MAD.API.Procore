using System.Net.Http;

namespace MAD.API.Procore
{
    public abstract class ProcorePaginatedRequest<TResponse> : ProcoreRequest<TResponse>
    {
        [RequestParameter("per_page")]
        public int PerPage { get; set; } = Constants.MaxResultsPerPage;

        [RequestParameter("page")]
        public int Page { get; set; } = 1;
    }
}
