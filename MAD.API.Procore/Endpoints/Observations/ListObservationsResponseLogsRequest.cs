using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Observations.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Observations
{
	public class ListObservationsResponseLogsRequest : ProcorePaginatedRequest<ArrayOfObservationItemResponseLog>
	{

		public override string Resource { get => $"/projects/{this.ProjectId}/observations/response_logs"; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")] public long ProjectId { get; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")] public int[]? Id { get; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")] public string? UpdatedAt { get; set; }
	}
}
