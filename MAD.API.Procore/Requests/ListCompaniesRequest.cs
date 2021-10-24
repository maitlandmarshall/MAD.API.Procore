using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListCompaniesRequest : ProcoreRequest<ArrayOfCompanies>
    {

        public override string Resource { get => $"/companies"; }
    }
}
