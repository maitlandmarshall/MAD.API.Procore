using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class InspectionChecklistRequest : ProcoreFilterableRequest<InspectionChecklist>
    {
        public override string Resource => "checklist/lists";

        [RequestParameter("project_id")]
        public long ProjectId { get; set; }
    }
}
