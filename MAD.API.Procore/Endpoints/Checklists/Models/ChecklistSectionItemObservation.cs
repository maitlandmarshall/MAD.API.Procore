using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ChecklistSectionItemObservation {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Number
		/// </summary>
		[JsonProperty("number")]	public  string Number { get ; set; }

		/// <summary>
		/// Status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Title
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Observation Type
		/// </summary>
		[JsonProperty("type")]	public  ChecklistSectionItemObservationType Type { get ; set; }

		[JsonProperty("assignee")]	public  ChecklistSectionItemObservationAssignee Assignee { get ; set; }

		[JsonProperty("created_by")]	public  ChecklistSectionItemObservationCreatedBy CreatedBy { get ; set; }
	}
}
