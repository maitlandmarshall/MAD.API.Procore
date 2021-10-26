using MAD.API.Procore.Endpoints.CoordinationIssuePotentialAssignees.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssuePotentialAssignees
{
    public class ListCoordinationIssueAssignableUsersRequest : ProcoreRequest<IEnumerable<CoordinationIssueAssignee>>
    {

        public override string Resource { get => $"/coordination_issues/assignees"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
