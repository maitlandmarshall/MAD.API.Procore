using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.DailyLogHeaders.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.DailyLogHeaders {
	public class GetDailyLogHeadersForTheProjectRequest : ProcorePaginatedRequest<IEnumerable<ADailyLogHeader>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/daily_log_headers/index";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// The left boundary of requested date range
		/// </summary>
		[RequestParameter("start_date")]	public  string? StartDate { get ; set; }

		/// <summary>
		/// The right boundary of requested date range
		/// </summary>
		[RequestParameter("end_date")]	public  string? EndDate { get ; set; }
	}
}
