using MAD.API.Procore.Endpoints.Observations.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.Observations
{
    public class ShowObservationItemRequest : ProcoreRequest<ObservationItem>
    {

        public override string Resource { get => $"/projects/{ProjectId}/observations/items/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Observation ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
