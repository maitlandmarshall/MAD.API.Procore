using MAD.API.Procore.Endpoints.Correspondences.Models;

using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences
{
    public class ListCorrespondenceTypeDefaultsRequest : ProcoreRequest<IEnumerable<CorrespondenceTypeDefault>>
    {
        public override string Resource { get => $"/projects/{ProjectId}/correspondence_types/defaults"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
