using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Incidents.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Incidents {
	public class ListIncidentsRequest : ProcorePaginatedRequest<ListIncidentsRequestResult> {

		public override string Resource { get => $"/projects/{this.ProjectId}/incidents";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")]	public  int[] Id { get ; set; }

		/// <summary>
		/// Return item(s) created within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string CreatedAt { get ; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string UpdatedAt { get ; set; }

		/// <summary>
		/// Returns item(s) with an event date within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[event_date]")]	public  string EventDate { get ; set; }

		/// <summary>
		/// Return item(s) with the specified Location IDs.
		/// </summary>
		[RequestParameter("filters[location_id]")]	public  int[] LocationId { get ; set; }

		/// <summary>
		/// Returns item(s) matching the specified status value.
		/// </summary>
		[RequestParameter("filters[status]")]	public  int[] Status { get ; set; }

		/// <summary>
		/// Contributing Behavior ID. Returns item(s) with the specified Contributing Behavior ID.
		/// </summary>
		[RequestParameter("filters[contributing_behavior_id]")]	public  int[] ContributingBehaviorId { get ; set; }

		/// <summary>
		/// Contributing Condition ID. Returns item(s) with the specified Contributing Condition ID.
		/// </summary>
		[RequestParameter("filters[contributing_condition_id]")]	public  int[] ContributingConditionId { get ; set; }

		/// <summary>
		/// Hazard ID. Returns item(s) with the specified Hazard ID.
		/// </summary>
		[RequestParameter("filters[hazard_id]")]	public  int[] HazardId { get ; set; }

		/// <summary>
		/// If true, returns item(s) where the time of Incident occurrence is unknown.
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
