using MAD.API.Procore.Endpoints.CoordinationIssueStatusChanges.Models;

using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssueStatusChanges
{
    public class ListStatusChangeHistoryForACoordinationIssueRequest : ProcoreRequest<IEnumerable<ListStatusChangeHistoryForACoordinationIssueRequestResult>>
    {

        public override string Resource { get => $"/coordination_issues/{Id}/status_changes"; }

        /// <summary>
        /// Coordination Issue ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// The extended view provides what is shown below.
        /// The normal view is the same as the extended view but excludes attribute created_by, linked_rfi and linked_observation_item.
        /// The compact view returns ids only.
        /// The default view is normal.
        /// Both linked_rfi or linked_observation_item can be empty objects, or at most one of them is populated.
        /// </summary>
        [RequestParameter("view")] public string View { get; set; }
    }
}
