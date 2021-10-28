using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListChecklistTemplatesRequest : ProcoreRequest<ArrayOfChecklistTemplates>
    {

        public override string Resource { get => $"/checklist/list_templates"; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}