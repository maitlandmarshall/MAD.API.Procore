using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListWorkActivitiesRequest : ProcoreRequest<ArrayOfWorkActivities> {

		public override string Resource { get => $"/vapid/companies/{this.CompanyId}/incidents/work_activities";}

		/// <summary>
		/// Company ID
		/// </summary>
		[RequestParameter("company_id")]	public  long? CompanyId { get ; set; }

		/// <summary>
		/// Return item(s) with specified active status
		/// </summary>
		[RequestParameter("filters[active]")]	public  bool Active { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs
		/// </summary>
		[RequestParameter("filters[id]")]	public  string[] Id { get ; set; }

		/// <summary>
		/// Return item(s) within a specific updated at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string UpdatedAt { get ; set; }

		[RequestParameter("sort")]	public  string Sort { get ; set; }
	}
}
