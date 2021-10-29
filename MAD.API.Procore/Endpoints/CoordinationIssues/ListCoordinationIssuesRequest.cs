using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.CoordinationIssues.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.CoordinationIssues
{
	public class ListCoordinationIssuesRequest : ProcorePaginatedRequest<IEnumerable<ListCoordinationIssuesRequestResult>>
	{

		public override string Resource { get => $"/coordination_issues"; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")] public long ProjectId { get; set; }

		/// <summary>
		/// Filter item(s) with matching assignee vendor companies.
		/// </summary>
		[RequestParameter("filters[assignee_company_id]")] public long? AssigneeCompanyId { get; set; }

		/// <summary>
		/// Filter item(s) with matching assignees.
		/// </summary>
		[RequestParameter("filters[assignee_id]")] public long? AssigneeId { get; set; }

		/// <summary>
		/// Filter item(s) with matching ids.
		/// </summary>
		[RequestParameter("filters[ids]")] public long? Ids { get; set; }

		/// <summary>
		/// Filter item(s) with matching locations.
		/// </summary>
		[RequestParameter("filters[location_id]")] public long? LocationId { get; set; }

		/// <summary>
		/// Use together with `filters[location_id]`
		/// 
		/// </summary>
		[RequestParameter("filters[include_sublocations]")] public bool? IncludeSublocations { get; set; }

		/// <summary>
		/// Filter item(s) with the matching search query. The search is performed on title and issue number.
		/// </summary>
		[RequestParameter("filters[search]")] public string? Search { get; set; }

		/// <summary>
		/// Filter item(s) with the exact coordination issue file.
		/// </summary>
		[RequestParameter("filters[coordination_issue_file_id]")] public string? CoordinationIssueFileId { get; set; }

		/// <summary>
		/// Filter item(s) with matching status.
		/// </summary>
		[RequestParameter("filters[status]")] public string? Status { get; set; }

		/// <summary>
		/// Filter item(s) with matching issue_type.
		/// </summary>
		[RequestParameter("filters[issue_type]")] public string? IssueType { get; set; }

		/// <summary>
		/// Filter item(s) with matching priority.
		/// </summary>
		[RequestParameter("filters[priority]")] public string? Priority { get; set; }

		/// <summary>
		/// Filter item(s) with matching trades.
		/// </summary>
		[RequestParameter("filters[trade_id]")] public long? TradeId { get; set; }

		/// <summary>
		/// Filter item(s) within a specific updated at iso8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")] public string? UpdatedAt { get; set; }

		/// <summary>
		/// Filter item(s) within a specific due date iso8601 date range.
		/// </summary>
		[RequestParameter("filters[due_date]")] public string? DueDate { get; set; }

		/// <summary>
		/// Filter item(s) within a specific created at iso8601 datetime range.
		/// </summary>
		[RequestParameter("filters[created_at]")] public string? CreatedAt { get; set; }

		/// <summary>
		/// Sort item(s) by an attribute. The default sort is ascending. To sort in descending order, prepend the sort value with a hyphen character '-'
		/// </summary>
		[RequestParameter("sort")] public string? Sort { get; set; }

		/// <summary>
		/// The compact view contains only ids.
		/// The normal view is a subset of the response shown below, and does not include attachments, viewpoints, linked items and updated_by
		/// The extended view contains the response shown below.
		/// The default view is normal.
		/// </summary>
		[RequestParameter("view")] public string? View { get; set; }

		/// <summary>
		/// Specify viewpoint data format. This parameter functions only when the query parameter view is 'extended'
		/// The default format returns the viewpoint content as saved.
		/// The procore format returns the viewpoint content converted to Procore format. If a valid conversion is not possible, empty viewpoint is returned.
		/// </summary>
		[RequestParameter("viewpoint_format")] public string? ViewpointFormat { get; set; }

		/// <summary>
		/// Persists filter parameters for the requesting user and project.
		/// </summary>
		[RequestParameter("save_sticky_filters")] public bool? SaveStickyFilters { get; set; }
	}
}
