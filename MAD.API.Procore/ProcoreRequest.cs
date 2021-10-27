using System.Net.Http;

namespace MAD.API.Procore
{
    public abstract class ProcoreRequest
    {
        public abstract string Resource { get; }
        public virtual HttpMethod HttpMethod { get; } = HttpMethod.Get;

        /// <summary>
		/// The HttpRequest Body
		/// </summary>
        public string Body { get; set; }

        [RequestParameter("per_page")]
        public int PerPage { get; set; } = Constants.MaxResultsPerPage;

        [RequestParameter("page")]
        public int Page { get; set; } = 1;
    }

    public abstract class ProcoreRequest<TResponse> : ProcoreRequest
    {

    }
}
