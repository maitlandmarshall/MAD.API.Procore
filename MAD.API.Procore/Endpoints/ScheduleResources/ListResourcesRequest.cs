using MAD.API.Procore.Endpoints.ScheduleResources.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.ScheduleResources
{
    public class ListResourcesRequest : ProcoreRequest<ListResourcesRequestResult>
    {

        public override string Resource { get => $"/resources"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
