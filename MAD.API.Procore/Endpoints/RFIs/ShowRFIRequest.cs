using MAD.API.Procore.Endpoints.RFIs.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.RFIs
{
    public class ShowRFIRequest : ProcoreRequest<ShowRFIRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/rfis/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// RFI ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
