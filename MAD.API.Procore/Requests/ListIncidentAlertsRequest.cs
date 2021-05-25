using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListIncidentAlertsRequest : ProcoreRequest<IEnumerable<Alert>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/incidents/alerts";}

		/// <summary>
		/// Project ID
		/// </summary>
		[RequestParameter("project_id")]	public  long? ProjectId { get ; set; }

		/// <summary>
		/// Incident ID
		/// </summary>
		[RequestParameter("incident_id")]	public  long IncidentId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs
		/// </summary>
		[RequestParameter("filters[id]")]	public  string[] Id { get ; set; }

		/// <summary>
		/// Return item(s) within a specific updated at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string UpdatedAt { get ; set; }

		/// <summary>
		/// Return item(s) with the specified Incident IDs
		/// </summary>
		[RequestParameter("filters[incident_id]")]	public  string[] IncidentIds { get ; set; }

		/// <summary>
		/// Return item(s) with the specified Injury IDs
		/// </summary>
		[RequestParameter("filters[injury_id]")]	public  string[] InjuryId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified recipient (User) IDs
		/// </summary>
		[RequestParameter("filters[recipient_id]")]	public  string[] RecipientId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified Incident Severity Level IDs
		/// </summary>
		[RequestParameter("filters[severity_level_id]")]	public  string[] SeverityLevelId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified triggered by (User) IDs
		/// </summary>
		[RequestParameter("filters[triggered_by_id]")]	public  string[] TriggeredById { get ; set; }

		[RequestParameter("sort")]	public  string Sort { get ; set; }
	}
}
