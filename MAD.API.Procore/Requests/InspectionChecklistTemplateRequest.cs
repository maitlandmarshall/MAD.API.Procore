using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class InspectionChecklistTemplateRequest : ProcoreFilterableRequest<ChecklistTemplate>
    {
        public override string Resource
        {
            get
            {
                if (this.CompanyId.HasValue)
                {
                    return $"companies/{this.CompanyId}/checklist/list_templates";
                }
                else
                {
                    return "checklist/list_templates";
                }
            }
        }

        public long? CompanyId { get; set; }

        [RequestParameter("project_id")]
        public long? ProjectId { get; set; }
    }
}
