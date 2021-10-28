using MAD.API.Procore.Endpoints.InspectionLogs.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.InspectionLogs
{
    public class ShowInspectionLogsRequest : ProcoreRequest<InspectionLog>
    {

        public override string Resource { get => $"/projects/{ProjectId}/inspection_logs/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Inspection Log ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
