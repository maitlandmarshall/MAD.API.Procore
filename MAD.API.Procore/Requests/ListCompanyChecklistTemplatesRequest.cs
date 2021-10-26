using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListCompanyChecklistTemplatesRequest : ProcoreRequest<ArrayOfCompanyChecklistTemplates>
    {

        public override string Resource { get => $"/companies/{CompanyId}/checklist/list_templates"; }

        /// <summary>
        /// Company ID
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }
    }
}
