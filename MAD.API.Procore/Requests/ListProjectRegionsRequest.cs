using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListProjectRegionsRequest : ProcoreRequest<ArrayOfProjectRegion>
    {

        public override string Resource { get => $"/companies/{CompanyId}/project_regions"; }

        /// <summary>
        /// Company ID
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }
    }
}
