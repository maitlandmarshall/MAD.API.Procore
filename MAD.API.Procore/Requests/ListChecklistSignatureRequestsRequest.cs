using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListChecklistSignatureRequestsRequest : ProcoreRequest<ArrayOfChecklistSignatureRequests>
    {

        public override string Resource { get => $"/checklist/lists/{ListId}/signature_requests"; }

        /// <summary>
        /// Checklist ID
        /// </summary>
        [RequestParameter("list_id")] public long? ListId { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
