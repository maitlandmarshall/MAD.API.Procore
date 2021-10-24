using MAD.API.Procore.Endpoints.Images.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.Images
{
    public class ShowImageRequest : ProcoreRequest<Image>
    {

        public override string Resource { get => $"/images/{Id}"; }

        /// <summary>
        /// ID of the image
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
