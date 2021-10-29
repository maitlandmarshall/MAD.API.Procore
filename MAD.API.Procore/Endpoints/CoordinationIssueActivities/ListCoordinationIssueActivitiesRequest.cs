using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.CoordinationIssueActivities.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.CoordinationIssueActivities {
	public class ListCoordinationIssueActivitiesRequest : ProcorePaginatedRequest<IEnumerable<ListCoordinationIssueActivitiesRequestResult>> {

		public override string Resource { get => $"/coordination_issue_activities";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")]	public  int[]? Id { get ; set; }

		/// <summary>
		/// Filter item(s) with coordination issues.
		/// </summary>
		[RequestParameter("filters[coordination_issue_id]")]	public  string? CoordinationIssueId { get ; set; }

		/// <summary>
		/// The compact view contains only ids.
		/// The extended view contains the response shown below.
		/// The normal view contains all attributes in extended view except activity_details.
		/// The default view is normal.
		/// </summary>
		[RequestParameter("view")]	public  string? View { get ; set; }

		/// <summary>
		/// Use 'only' for only deleted resources. Use 'with' for deleted and undeleted resources.
		/// </summary>
		[RequestParameter("filters[include_deleted]")]	public  string? IncludeDeleted { get ; set; }
	}
}
