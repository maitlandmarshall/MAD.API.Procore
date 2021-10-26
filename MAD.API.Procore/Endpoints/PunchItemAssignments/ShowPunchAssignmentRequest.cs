using MAD.API.Procore.Endpoints.PunchItemAssignments.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.PunchItemAssignments
{
    public class ShowPunchAssignmentRequest : ProcoreRequest<PunchAssignment>
    {

        public override string Resource { get => $"/projects/{ProjectId}/punch_item_assignments/{Id}"; }

        /// <summary>
        /// ID of the Punch Item Assignment
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
