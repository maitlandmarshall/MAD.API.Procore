using MAD.API.Procore.Models;
using System.Collections.Generic;
namespace MAD.API.Procore.Requests
{
    public class ListIncidentAlertRecipientsRequest : ProcoreRequest<IEnumerable<ArrayOfIncidentAlertRecipients>>
    {

        public override string Resource { get => $"/companies/{CompanyId}/incidents/severity_levels/{SeverityLevelId}/alert_recipients"; }

        /// <summary>
        /// Company ID
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }

        /// <summary>
        /// Incident Severity Level ID
        /// </summary>
        [RequestParameter("severity_level_id")] public long? SeverityLevelId { get; set; }

        [RequestParameter("sort")] public string Sort { get; set; }
    }
}
