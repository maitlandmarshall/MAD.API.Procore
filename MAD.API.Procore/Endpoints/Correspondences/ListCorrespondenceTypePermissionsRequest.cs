using MAD.API.Procore.Endpoints.Correspondences.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences
{
    public class ListCorrespondenceTypePermissionsRequest : ProcoreRequest<IEnumerable<CorrespondenceTypesAndTheirPermission>>
    {
        public override string Resource { get => $"/projects/{ProjectId}/correspondence_types/permissions"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
