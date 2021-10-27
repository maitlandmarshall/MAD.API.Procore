using MAD.API.Procore.Endpoints.Forms.Models;

namespace MAD.API.Procore.Endpoints.Forms
{
    public class ShowFormRequest : ProcoreRequest<ShowFormRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/forms/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Form ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
