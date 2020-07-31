using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListPropertyDamagesRequest : ProcoreRequest<ListPropertyDamagesRequestResult> {

		public override string Resource { get => $"/vapid/projects/{this.ProjectId}/incidents/property_damages";}

		/// <summary>
		/// Project ID
		/// </summary>
		[RequestParameter("project_id")]	public  long? ProjectId { get ; set; }

		/// <summary>
		/// Incident ID. When provided, the list will be scoped to only the Property Damages for a given Incident.
		/// </summary>
		[RequestParameter("incident_id")]	public  long IncidentId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified Vendor IDs
		/// </summary>
		[RequestParameter("filters[responsible_company_id]")]	public  string[] ResponsibleCompanyId { get ; set; }

		/// <summary>
		/// Return item(s) containing search query
		/// </summary>
		[RequestParameter("filters[query]")]	public  string Query { get ; set; }

		[RequestParameter("sort")]	public  string Sort { get ; set; }
	}
}
