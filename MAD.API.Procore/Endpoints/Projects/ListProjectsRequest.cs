using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Projects.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Projects
{
	public class ListProjectsRequest : ProcorePaginatedRequest<IEnumerable<Project>>
	{

		public override string Resource { get => $"/projects"; }

		/// <summary>
		/// Unique identifier for the company.
		/// </summary>
		[RequestParameter("company_id")] public long CompanyId { get; set; }

		/// <summary>
		/// Filters on project status. Must be one of Active, Inactive, or All.
		/// </summary>
		[RequestParameter("filters[by_status]")] public string? ByStatus { get; set; }

		/// <summary>
		/// Return item(s) created within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[created_at]")] public string? CreatedAt { get; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")] public string? UpdatedAt { get; set; }

		/// <summary>
		/// Origin ID. Returns item(s) with the specified Origin ID.
		/// </summary>
		[RequestParameter("filters[origin_id]")] public string? OriginId { get; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")] public int[]? Id { get; set; }

		/// <summary>
		/// If true, returns only item(s) with a `synced` status.
		/// </summary>
		[RequestParameter("filters[synced]")] public bool? Synced { get; set; }

		/// <summary>
		/// Return item(s) with the specified Vendor ID.
		/// </summary>
		[RequestParameter("filters[vendor_id]")] public long? VendorId { get; set; }

		/// <summary>
		/// The 'compact' view only returns id and name. Passing any other value (or passing no value at all)
		/// will result in the more complete list of attributes shown below.
		/// </summary>
		[RequestParameter("serializer_view")] public string? SerializerView { get; set; }

		/// <summary>
		/// Return items with the specified sort.
		/// </summary>
		[RequestParameter("sort")] public string? Sort { get; set; }
	}
}
