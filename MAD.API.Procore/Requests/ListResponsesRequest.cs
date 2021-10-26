using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListResponsesRequest : ProcoreRequest<ArrayOfResponses>
    {

        public override string Resource { get => $"/companies/{CompanyId}/checklist/responses"; }

        /// <summary>
        /// Company ID
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Corresponding Statuses
        /// </summary>
        [RequestParameter("filters[corresponding_status]")] public string[] CorrespondingStatus { get; set; }

        [RequestParameter("sort")] public string Sort { get; set; }
    }
}
