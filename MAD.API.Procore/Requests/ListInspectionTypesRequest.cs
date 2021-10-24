using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListInspectionTypesRequest : ProcoreRequest<ArrayOfInspectionTypes>
    {

        public override string Resource { get => $"/companies/{CompanyId}/inspection_types"; }

        /// <summary>
        /// Company ID
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }
    }
}
