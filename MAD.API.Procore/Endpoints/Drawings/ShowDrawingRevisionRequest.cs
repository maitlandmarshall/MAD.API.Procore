using MAD.API.Procore.Endpoints.Drawings.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.Drawings
{
    public class ShowDrawingRevisionRequest : ProcoreRequest<DrawingRevision>
    {

        public override string Resource { get => $"/projects/{ProjectId}/drawing_revisions/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// ID of the Drawing Revision
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
