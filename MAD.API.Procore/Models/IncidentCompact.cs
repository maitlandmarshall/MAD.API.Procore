using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class IncidentCompact {

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Timestamp of deletion
		/// </summary>
		[JsonProperty("deleted_at")]		public DateTimeOffset? DeletedAt { get; set; }

		/// <summary>
		/// Description of the Incident
		/// </summary>
		[JsonProperty("description")]		public string Description { get; set; }

		/// <summary>
		/// Date of Incident occurrence
		/// </summary>
		[JsonProperty("event_date")]		public DateTimeOffset? EventDate { get; set; }

		/// <summary>
		/// Number
		/// </summary>
		[JsonProperty("number")]		public int? Number { get; set; }

		/// <summary>
		/// Indicates whether an Incident is private
		/// </summary>
		[JsonProperty("private")]		public bool Private { get; set; }

		/// <summary>
		/// Indicates whether an Incident is recordable
		/// </summary>
		[JsonProperty("recordable")]		public bool Recordable { get; set; }

		/// <summary>
		/// Number of Records associated to the Incident
		/// </summary>
		[JsonProperty("records_count")]		public int? RecordsCount { get; set; }

		/// <summary>
		/// Number of Open Observations associated to the Incident
		/// </summary>
		[JsonProperty("open_observations_count")]		public int? OpenObservationsCount { get; set; }

		/// <summary>
		/// Number of Closed Observations associated to the Incident
		/// </summary>
		[JsonProperty("closed_observations_count")]		public int? ClosedObservationsCount { get; set; }

		/// <summary>
		/// Number of Actions associated to the Incident
		/// </summary>
		[JsonProperty("actions_count")]		public int? ActionsCount { get; set; }

		/// <summary>
		/// Number of Witness Statements associated to the Incident
		/// </summary>
		[JsonProperty("witness_statements_count")]		public int? WitnessStatementsCount { get; set; }

		/// <summary>
		/// Status
		/// </summary>
		[JsonProperty("status")]		public string Status { get; set; }

		/// <summary>
		/// Indicates that the time of the Incident occurrence is unknown
		/// </summary>
		[JsonProperty("time_unknown")]		public bool TimeUnknown { get; set; }

		/// <summary>
		/// Incident Title
		/// </summary>
		[JsonProperty("title")]		public string Title { get; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("created_by")]		public CreatedBy CreatedBy { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("contributing_behavior")]		public ContributingBehavior ContributingBehavior { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("contributing_condition")]		public ContributingCondition ContributingCondition { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("hazard")]		public Hazard Hazard { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("location")]		public Location Location { get; set; }

		/// <summary>
		/// Number of Attachments attached to the Incident
		/// </summary>
		[JsonProperty("attachments_count")]		public int? AttachmentsCount { get; set; }
	}
}
