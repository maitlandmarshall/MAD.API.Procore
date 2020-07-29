using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class InspectionPossibleInspectorRequest : ProcoreRequest<Inspector>
    {
        public override string Resource => "checklist/possible_inspectors";

        [RequestParameter("project_id")]
        public long ProjectId { get; set; }
    }
}
