using MAD.API.Procore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public class ManpowerLogRequest : ProcoreRequest<object>
    {
        public override string Resource => $"projects/{this.ProjectId}/manpower_logs";

        public long ProjectId { get; set; }

        [RequestParameter("log_date")]
        public DateTime? LogDate { get; set; }

        [RequestParameter("start_date")]
        public DateTime? StartDate { get; set; }

        [RequestParameter("end_date")]
        public DateTime? EndDate { get; set; }
    }
}
