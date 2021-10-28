using MAD.API.Procore.Endpoints.ProjectDates.Models;

namespace MAD.API.Procore.Endpoints.ProjectDates
{
    public class ListProjectDatesRequest : ProcoreRequest<ProjectDatesMaster>
    {
        public override string Resource { get => $"/projects/{ProjectId}/project_dates"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
