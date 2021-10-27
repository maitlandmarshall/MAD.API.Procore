using MAD.API.Procore.Endpoints.Drawings.Models;

using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Drawings
{
    public class ListDrawingUploadsRequest : ProcoreRequest<IEnumerable<DrawingUpload>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/drawing_uploads"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
