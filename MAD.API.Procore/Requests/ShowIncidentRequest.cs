using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ShowIncidentRequest : ProcoreRequest<IncidentCompact>
    {

        public override string Resource { get => $"/projects/{ProjectId}/incidents/{Id}"; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Incident ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
