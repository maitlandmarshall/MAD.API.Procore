using MAD.API.Procore.Endpoints.Forms.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.Forms
{
    public class ShowFormRequest : ProcoreRequest<Form>
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
