using MAD.API.Procore.Endpoints.Transmittals.Models;

namespace MAD.API.Procore.Endpoints.Transmittals
{
    public class ShowTransmittalRequest : ProcoreRequest<Transmittal>
    {

        public override string Resource { get => $"/transmittals/{Id}"; }

        /// <summary>
        /// Transmittal ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
