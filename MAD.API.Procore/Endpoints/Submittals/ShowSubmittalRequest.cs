using MAD.API.Procore.Endpoints.Submittals.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.Submittals
{
    public class ShowSubmittalRequest : ProcoreRequest<ShowSubmittalRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/submittals/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Submittal ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
