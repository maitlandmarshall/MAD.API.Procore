using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class ProjectPeopleRequest : ProcoreRequest<ProjectPeople>
    {
        public override string Resource => $"projects/{ProjectId}/people";

        public double ProjectId { get; set; }
    }
}
