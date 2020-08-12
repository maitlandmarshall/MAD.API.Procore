using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListIncidentsRequest : ProcoreRequest<ListIncidentsRequestResult> {

		public override string Resource { get => $"/vapid/projects/{this.ProjectId}/incidents";}

		/// <summary>
		/// Project ID
		/// </summary>
		[RequestParameter("project_id")]	public  long? ProjectId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs
		/// </summary>
		[RequestParameter("filters[id]")]	public  string[] Id { get ; set; }

		/// <summary>
		/// Return item(s) within a specific created at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string CreatedAt { get ; set; }

		/// <summary>
		/// Return item(s) within a specific updated at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string UpdatedAt { get ; set; }

		/// <summary>
		/// Return item(s) within a specific event date range. This assumes the dates provided are in the project timezone.
		/// </summary>
		[RequestParameter("filters[event_date]")]	public  string EventDate { get ; set; }

		/// <summary>
		/// Return item(s) with the specified Location IDs
		/// </summary>
		[RequestParameter("filters[location_id]")]	public  string[] LocationId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified statuses
		/// </summary>
		[RequestParameter("filters[status]")]	public  long? Status { get ; set; }

		/// <summary>
		/// Return item(s) with a specific Contributing Behavior ID
		/// </summary>
		[RequestParameter("filters[contributing_behavior_id]")]	public  string[] ContributingBehaviorId { get ; set; }

		/// <summary>
		/// Return item(s) with a specific Contributing Condition ID
		/// </summary>
		[RequestParameter("filters[contributing_condition_id]")]	public  string[] ContributingConditionId { get ; set; }

		/// <summary>
		/// Return item(s) with a specific Hazard ID
		/// </summary>
		[RequestParameter("filters[hazard_id]")]	public  string[] HazardId { get ; set; }

		/// <summary>
		/// Return item(s) where time of Incident occurrence is unknown
		/// </summary>
		[RequestParameter("filters[time_unknown]")]	public  bool? TimeUnknown { get ; set; }

		/// <summary>
		/// Return item(s) that are recordable.
		/// </summary>
		[RequestParameter("filters[recordable]")]	public  bool? Recordable { get ; set; }

		/// <summary>
		/// Return item(s) containing query. Searchable fields include Incident title, Creator, Witness Statement, Incident Action description, Incident Action Type, Contributing Behavior, Contributing Condition, Hazard, and Location.
		/// </summary>
		[RequestParameter("filters[query]")]	public  string Query { get ; set; }

		[RequestParameter("sort")]	public  string Sort { get ; set; }
	}
}
