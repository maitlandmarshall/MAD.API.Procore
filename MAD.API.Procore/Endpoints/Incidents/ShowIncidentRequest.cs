using MAD.API.Procore.Endpoints.Incidents.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.Incidents
{
    public class ShowIncidentRequest : ProcoreRequest<IncidentCompact>
    {

        public override string Resource { get => $"/projects/{ProjectId}/incidents/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Incident ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
