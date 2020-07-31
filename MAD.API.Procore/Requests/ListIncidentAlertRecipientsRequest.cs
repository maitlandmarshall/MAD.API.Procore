using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListIncidentAlertRecipientsRequest : ProcoreRequest<IEnumerable<ArrayOfIncidentAlertRecipients>> {

		public override string Resource { get => $"/vapid/companies/{this.CompanyId}/incidents/severity_levels/{this.SeverityLevelId}/alert_recipients";}

		/// <summary>
		/// Company ID
		/// </summary>
		[RequestParameter("company_id")]	public  long? CompanyId { get ; set; }

		/// <summary>
		/// Incident Severity Level ID
		/// </summary>
		[RequestParameter("severity_level_id")]	public  long? SeverityLevelId { get ; set; }

		[RequestParameter("sort")]	public  string Sort { get ; set; }
	}
}
