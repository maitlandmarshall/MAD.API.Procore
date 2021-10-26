using MAD.API.Procore.Endpoints.ProjectDates.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.ProjectDates
{
    public class ListProjectDatesRequest : ProcoreRequest<ListProjectDatesRequestResult>
    {
        public override string Resource { get => $"/projects/{ProjectId}/project_dates"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
