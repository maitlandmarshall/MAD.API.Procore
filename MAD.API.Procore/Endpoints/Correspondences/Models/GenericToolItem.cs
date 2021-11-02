using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences.Models {
	public class GenericToolItem {

		/// <summary>
		/// Unique identifier for the Generic Tool Item
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Generic Tool Item closed at
		/// </summary>
		[JsonProperty("closed_at")]	public  DateTimeOffset? ClosedAt { get ; set; }

		/// <summary>
		/// Generic Tool Item created at
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Description of a Generic Tool Item
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Generic Tool Item Due Date
		/// </summary>
		[JsonProperty("due_date")]	public  string DueDate { get ; set; }

		/// <summary>
		/// Generic Tool Item issued at
		/// </summary>
		[JsonProperty("issued_at")]	public  DateTimeOffset? IssuedAt { get ; set; }

		/// <summary>
		/// The Number of the Generic Tool Item
		/// </summary>
		[JsonProperty("position")]	public  string Position { get ; set; }

		/// <summary>
		/// If the Generic Tool Item is private
		/// </summary>
		[JsonProperty("private")]	public  bool Private { get ; set; }

		[JsonProperty("schedule_impact")]	public  GenericToolItemScheduleImpact ScheduleImpact { get ; set; }

		[JsonProperty("cost_impact")]	public  GenericToolItemCostImpact CostImpact { get ; set; }

		/// <summary>
		/// Generic Tool Item updated at
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// Status of the Generic Tool Item
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Title of the Generic Tool Item
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		[JsonProperty("created_by")]	public  GenericToolItemCreatedBy CreatedBy { get ; set; }

		[JsonProperty("received_from")]	public  GenericToolItemReceivedFrom ReceivedFrom { get ; set; }

		[JsonProperty("location")]	public  Location Location { get ; set; }

		[JsonProperty("cost_code")]	public  GenericToolItemCostCode CostCode { get ; set; }

		[JsonProperty("specification_section")]	public  GenericToolItemSpecificationSection SpecificationSection { get ; set; }

		[JsonProperty("trade")]	public  Trade Trade { get ; set; }

		[JsonProperty("generic_tool")]	public  GenericToolItemGenericTool GenericTool { get ; set; }

		/// <summary>
		/// Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<GenericToolItemAttachment> Attachments { get ; set; }

		/// <summary>
		/// Distribution Members
		/// </summary>
		[JsonProperty("distribution_members")]	public  List<GenericToolItemDistributionMember> DistributionMembers { get ; set; }

		/// <summary>
		/// Assignees
		/// </summary>
		[JsonProperty("assignees")]	public  List<GenericToolItemAssignee> Assignees { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }
	}
}
