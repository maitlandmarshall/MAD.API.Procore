using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class ProjectLocationRequest : ProcoreRequest<ProjectLocation>
    {
        public override string Resource => "locations";

        [RequestParameter("project_id")]
        public long ProjectId { get; set; }
    }
}
