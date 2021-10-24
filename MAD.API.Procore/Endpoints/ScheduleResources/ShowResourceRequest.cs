using MAD.API.Procore.Endpoints.ScheduleResources.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.ScheduleResources
{
    public class ShowResourceRequest : ProcoreRequest<Resource>
    {

        public override string Resource { get => $"/resources/{Id}"; }

        /// <summary>
        /// ID of the resource
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
