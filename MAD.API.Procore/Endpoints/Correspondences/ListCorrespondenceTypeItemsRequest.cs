using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Correspondences.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Correspondences {
	public class ListCorrespondenceTypeItemsRequest : ProcorePaginatedRequest<CorrespondenceTypeItem> {

		public override string Resource { get => $"/projects/{this.ProjectId}/correspondence_type_items";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")]	public  int[]? Id { get ; set; }

		/// <summary>
		/// Array of Login Information IDs. Returns item(s) with the specified Login Information ID.
		/// </summary>
		[RequestParameter("filters[login_information_id]")]	public  int[]? LoginInformationId { get ; set; }

		/// <summary>
		/// Returns item(s) matching the specified status value.
		/// </summary>
		[RequestParameter("filters[status]")]	public  string[]? Status { get ; set; }

		/// <summary>
		/// If true, returns item(s) that are overdue.
		/// </summary>
		[RequestParameter("filters[overdue]")]	public  bool? Overdue { get ; set; }

		/// <summary>
		/// Return item(s) containing search query
		/// </summary>
		[RequestParameter("filters[query]")]	public  string? Query { get ; set; }

		/// <summary>
		/// If true, returns item(s) that have been deleted.
		/// </summary>
		[RequestParameter("filters[recycle_bin]")]	public  bool? RecycleBin { get ; set; }

		/// <summary>
		/// If true, returns item(s) within the specified Generic Tool ID.
		/// </summary>
		[RequestParameter("filters[generic_tool_id]")]	public  bool? GenericToolId { get ; set; }

		/// <summary>
		/// Received From ID
		/// </summary>
		[RequestParameter("filters[received_from_id]")]	public  long? ReceivedFromId { get ; set; }

		/// <summary>
		/// Returns item(s) created by the specified User IDs.
		/// </summary>
		[RequestParameter("filters[created_by_id]")]	public  int[]? CreatedById { get ; set; }

		/// <summary>
		/// Return item(s) created within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string? CreatedAt { get ; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string? UpdatedAt { get ; set; }

		/// <summary>
		/// Returns item(s) closed within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[closed_at]")]	public  string? ClosedAt { get ; set; }

		/// <summary>
		/// Returns item(s) issued within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[issued_at]")]	public  string? IssuedAt { get ; set; }

		/// <summary>
		/// Return item(s) with the specified Vendor ID.
		/// </summary>
		[RequestParameter("filters[vendor_id]")]	public  long? VendorId { get ; set; }

		/// <summary>
		/// Field to sort by. If the field is passed with a - (EX: -updated_at) it is sorted in reverse order
		/// </summary>
		[RequestParameter("sort")]	public  string? Sort { get ; set; }

		/// <summary>
		/// Defines the type of view returned. Must be one of 'extended', 'compact', 'ids_only', or 'flatten_v0'.
		/// </summary>
		[RequestParameter("view")]	public  string? View { get ; set; }
	}
}
