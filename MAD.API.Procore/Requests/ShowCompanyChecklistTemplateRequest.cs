using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ShowCompanyChecklistTemplateRequest : ProcoreRequest<ChecklistTemplate>
    {

        public override string Resource { get => $"/companies/{CompanyId}/checklist/list_templates/{ListTemplateId}"; }

        /// <summary>
        /// Company Checklist Template ID
        /// </summary>
        [RequestParameter("list_template_id")] public long? ListTemplateId { get; set; }

        /// <summary>
        /// Company ID
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }
    }
}
