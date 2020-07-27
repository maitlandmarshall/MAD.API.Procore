using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class InspectionChecklistTemplateRequest : ProcoreFilterableRequest<InspectionChecklistTemplate>
    {
        public override string Resource
        {
            get => $"companies/{this.CompanyId}/checklist/list_templates";
        }

        public long CompanyId { get; set; }
    }
}
