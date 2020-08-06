using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListChecklistsRequest : ProcoreRequest<IEnumerable<ArrayOfChecklistGroupedByTemplate>> {

		public override string Resource { get => $"/vapid/checklist/lists";}

		/// <summary>
		/// Project ID
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// If 'recycle' show deleted Checklists.
		/// </summary>
		[RequestParameter("filters[view]")]	public  string View { get ; set; }

		/// <summary>
		/// Array of Inspection Type IDs. Return item(s) associated to the specified Inspection Type IDs.
		/// </summary>
		[RequestParameter("filters[inspection_type_id]")]	public  string[] InspectionTypeId { get ; set; }

		/// <summary>
		/// Array of User IDs. Return item(s) where the specified User IDs are the point of contact.
		/// </summary>
		[RequestParameter("filters[point_of_contact_id]")]	public  string[] PointOfContactId { get ; set; }

		/// <summary>
		/// Array of User IDs. Return item(s) where the specified User IDs are inspectors.
		/// </summary>
		[RequestParameter("filters[inspector_id]")]	public  string[] InspectorId { get ; set; }

		/// <summary>
		/// Array of Checklist Template IDs. Return item(s) associated to the specified Checklist Template IDs.
		/// </summary>
		[RequestParameter("filters[list_template_id]")]	public  string[] ListTemplateId { get ; set; }

		/// <summary>
		/// Filters by specific location (Note: Use *either* this or location_id_with_sublocations, but not both)
		/// </summary>
		[RequestParameter("filters[location_id]")]	public  long? LocationId { get ; set; }

		/// <summary>
		/// Array of Specification Section IDs. Return item(s) associated to the specified Specification Section IDs.
		/// </summary>
		[RequestParameter("filters[spec_section_id]")]	public  string[] SpecSectionId { get ; set; }

		/// <summary>
		/// Array of Vendor IDs. Return item(s) where the specified Vendor IDs are the responsible contractor.
		/// </summary>
		[RequestParameter("filters[responsible_contractor_id]")]	public  string[] ResponsibleContractorId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified statuses
		/// </summary>
		[RequestParameter("filters[status]")]	public  long? Status { get ; set; }

		/// <summary>
		/// Trade ID
		/// </summary>
		[RequestParameter("filters[trade_id]")]	public  long? TradeId { get ; set; }

		/// <summary>
		/// Search query
		/// </summary>
		[RequestParameter("filters[search]")]	public  string Search { get ; set; }

		/// <summary>
		/// Return item(s) due within the specified date range.
		/// </summary>
		[RequestParameter("filters[due_at]")]	public  string DueAt { get ; set; }

		/// <summary>
		/// Return item(s) within a specific created at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string CreatedAt { get ; set; }

		/// <summary>
		/// Return item(s) within a specific updated at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string UpdatedAt { get ; set; }
	}
}
