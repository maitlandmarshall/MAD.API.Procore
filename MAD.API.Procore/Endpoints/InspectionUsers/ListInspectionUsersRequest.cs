using MAD.API.Procore.Endpoints.InspectionUsers.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.InspectionUsers
{
    public class ListInspectionUsersRequest : ProcoreRequest<ListInspectionUsersRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/checklist/users"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
