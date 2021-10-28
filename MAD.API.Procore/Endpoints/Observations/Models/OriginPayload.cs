using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Observations.Models {
	public class OriginPayload {

		/// <summary>
		/// Checklist Item ID
		/// </summary>
		[JsonProperty("checklist_item_id")]	public  long? ChecklistItemId { get ; set; }

		/// <summary>
		/// Checklist List ID
		/// </summary>
		[JsonProperty("checklist_list_id")]	public  long? ChecklistListId { get ; set; }

		/// <summary>
		/// Coordination Issue ID the Observation Item belongs to
		/// </summary>
		[JsonProperty("coordination_issue_id")]	public  long? CoordinationIssueId { get ; set; }

		/// <summary>
		/// Coordination Issue Number the Observation Item belongs to
		/// </summary>
		[JsonProperty("coordination_issue_number")]	public  int? CoordinationIssueNumber { get ; set; }

		/// <summary>
		/// Incident action Id the Observation Item belongs to
		/// </summary>
		[JsonProperty("incident_action_id")]	public  long? IncidentActionId { get ; set; }

		/// <summary>
		/// Incident Id the Observation Item belongs to
		/// </summary>
		[JsonProperty("incident_id")]	public  long? IncidentId { get ; set; }

		/// <summary>
		/// Bim model Id the Observation Item belongs to
		/// </summary>
		[JsonProperty("bim_model_id")]	public  long? BimModelId { get ; set; }

		/// <summary>
		/// Bim model name the Observation Item belongs to
		/// </summary>
		[JsonProperty("bim_model_name")]	public  string BimModelName { get ; set; }
	}
}
