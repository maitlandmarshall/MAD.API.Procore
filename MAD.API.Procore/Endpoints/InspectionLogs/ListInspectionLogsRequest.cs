using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.InspectionLogs.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.InspectionLogs
{
	public class ListInspectionLogsRequest : ProcorePaginatedRequest<IEnumerable<ListInspectionLogsRequestResult>>
	{

		public override string Resource { get => $"/projects/{this.ProjectId}/inspection_logs"; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")] public long ProjectId { get; set; }

		/// <summary>
		/// Date of specific logs desired in YYYY-MM-DD format
		/// </summary>
		[RequestParameter("log_date")] public string? LogDate { get; set; }

		/// <summary>
		/// Start date of specific logs desired in YYYY-MM-DD format (use together with end_date)
		/// </summary>
		[RequestParameter("start_date")] public string? StartDate { get; set; }

		/// <summary>
		/// End date of specific logs desired in YYYY-MM-DD format (use together with start_date)
		/// </summary>
		[RequestParameter("end_date")] public string? EndDate { get; set; }

		/// <summary>
		/// Returns item(s) created by the specified User IDs.
		/// </summary>
		[RequestParameter("filters[created_by_id]")] public int[]? CreatedById { get; set; }

		/// <summary>
		/// Return item(s) with the specified Location IDs.
		/// </summary>
		[RequestParameter("filters[location_id]")] public int[]? LocationId { get; set; }
	}
}
