using MAD.API.Procore.Endpoints.CoordinationIssueStatusTotals.Models;

namespace MAD.API.Procore.Endpoints.CoordinationIssueStatusTotals
{
    public class ShowCoordinationIssueCountByStatusRequest : ProcoreRequest<CoordinationIssueCounts>
    {

        public override string Resource { get => $"/coordination_issues/status_total"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
