using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class ProjectsRequest : ProcoreFilterableRequest<Project>
    {
        public override string Resource => "projects";

        [RequestParameter("company_id")]
        public long CompanyId { get; set; }
    }
}
