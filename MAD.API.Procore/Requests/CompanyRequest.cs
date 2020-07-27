using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class CompanyRequest : ProcoreRequest<Company>
    {
        public override string Resource => "companies";
    }
}
