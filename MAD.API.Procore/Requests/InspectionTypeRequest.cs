using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class InspectionTypeRequest : ProcoreRequest<InspectionType>
    {
        public override string Resource
        {
            get => $"companies/{this.CompanyId}/inspection_types";
        }

        public long CompanyId { get; set; }
    }
}
