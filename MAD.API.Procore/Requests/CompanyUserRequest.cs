using MAD.API.Procore.Models;

namespace MAD.API.Procore.Requests
{
    public class CompanyUserRequest : ProcoreFilterableRequest<User>
    {
        public override string Resource { get => $"companies/{this.CompanyId}/users"; }

        public long CompanyId { get; set; }

        [RequestParameter("filters[active]")]
        public bool Active { get; set; }
    }
}
