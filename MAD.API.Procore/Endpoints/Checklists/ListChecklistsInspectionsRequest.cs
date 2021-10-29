using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Checklists.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Checklists
{
	public class ListChecklistsInspectionsRequest : ProcorePaginatedRequest<ArrayOfChecklist>
	{

		public override string Resource { get => $"/projects/{this.ProjectId}/checklist/lists"; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")] public long ProjectId { get; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")] public int[]? Id { get; set; }

		/// <summary>
		/// Return item(s) with inspection date within the specified ISO 8601 date range.
		/// </summary>
		[RequestParameter("filters[inspection_date]")] public string? InspectionDate { get; set; }

		/// <summary>
		/// Array of Inspection Type IDs. Return item(s) associated with the specified Inspection Type IDs.
		/// </summary>
		[RequestParameter("filters[inspection_type_id]")] public int[]? InspectionTypeId { get; set; }

		/// <summary>
		/// Array of User IDs. Return item(s) where the specified User IDs are inspectors.
		/// </summary>
		[RequestParameter("filters[inspector_id]")] public int[]? InspectorId { get; set; }

		/// <summary>
		/// Array of Checklist Template IDs. Return item(s) associated to the specified Checklist Template IDs.
		/// </summary>
		[RequestParameter("filters[template_id]")] public int[]? TemplateId { get; set; }

		/// <summary>
		/// Location ID. Returns item(s) with the specified Location ID or a range of Location IDs.
		/// </summary>
		[RequestParameter("filters[location_id]")] public int[]? LocationId { get; set; }

		/// <summary>
		/// Return item(s) with the specified Managed Equipment ID.
		/// </summary>
		[RequestParameter("filters[managed_equipment_id]")] public long? ManagedEquipmentId { get; set; }

		/// <summary>
		/// Array of User IDs. Return item(s) where the specified User IDs are the point of contact.
		/// </summary>
		[RequestParameter("filters[point_of_contact_id]")] public int[]? PointOfContactId { get; set; }

		/// <summary>
		/// Array of Specification Section IDs. Return item(s) associated to the specified Specification Section IDs.
		/// </summary>
		[RequestParameter("filters[spec_section_id]")] public int[]? SpecSectionId { get; set; }

		/// <summary>
		/// Array of Vendor IDs. Return item(s) where the specified Vendor IDs are the responsible contractor.
		/// </summary>
		[RequestParameter("filters[responsible_contractor_id]")] public int[]? ResponsibleContractorId { get; set; }

		/// <summary>
		/// Array of User IDs. Return item(s) closed by the specified User ID.
		/// </summary>
		[RequestParameter("filters[closed_by_id]")] public int[]? ClosedById { get; set; }

		/// <summary>
		/// Return item(s) with the specified statuses
		/// </summary>
		[RequestParameter("filters[status]")] public long? Status { get; set; }

		/// <summary>
		/// Trade ID
		/// </summary>
		[RequestParameter("filters[trade_id]")] public long? TradeId { get; set; }

		/// <summary>
		/// Return item(s) containing search query
		/// </summary>
		[RequestParameter("filters[query]")] public string? Query { get; set; }

		/// <summary>
		/// Return item(s) due within the specified date range.
		/// </summary>
		[RequestParameter("filters[due_at]")] public string? DueAt { get; set; }

		/// <summary>
		/// Return item(s) created within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[created_at]")] public string? CreatedAt { get; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")] public string? UpdatedAt { get; set; }

		/// <summary>
		/// Returns item(s) closed within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[closed_at]")] public string? ClosedAt { get; set; }

		[RequestParameter("sort")] public string? Sort { get; set; }
	}
}
