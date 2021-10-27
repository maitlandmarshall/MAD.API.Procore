using MAD.API.Procore.Endpoints.Schedule.Models;

namespace MAD.API.Procore.Endpoints.Schedule
{
    public class GetScheduleMetadataRequest : ProcoreRequest<ScheduleMetadata>
    {

        public override string Resource { get => $"/projects/{ProjectId}/schedule"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
