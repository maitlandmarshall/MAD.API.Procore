using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Checklist {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// Checklist Template ID
		/// </summary>
		[JsonProperty("list_template_id")]		public int? ListTemplateId { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }

		/// <summary>
		/// Name of the Template the Inspection was created from
		/// </summary>
		[JsonProperty("list_template_name")]		public string ListTemplateName { get; set; }

		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("description")]		public string Description { get; set; }

		/// <summary>
		/// Users on the Inspection distribution list
		/// </summary>
		[JsonProperty("distribution_members")]		public DistributionMembers[] DistributionMembers { get; set; }

		/// <summary>
		/// Timestamp indicating when the Inspection is due
		/// </summary>
		[JsonProperty("due_at")]		public DateTimeOffset? DueAt { get; set; }

		/// <summary>
		/// Number
		/// </summary>
		[JsonProperty("number")]		public int? Number { get; set; }

		/// <summary>
		/// Status
		/// </summary>
		[JsonProperty("status")]		public string Status { get; set; }

		/// <summary>
		/// Date that the inspection was performed
		/// </summary>
		[JsonProperty("inspection_date")]		public string InspectionDate { get; set; }

		/// <summary>
		/// Timestamp of inspection creation
		/// </summary>
		[JsonProperty("created_at")]		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>
		/// Timestamp of when inspection was closed
		/// </summary>
		[JsonProperty("closed_at")]		public DateTimeOffset? ClosedAt { get; set; }

		/// <summary>
		/// Checklist Item count
		/// </summary>
		[JsonProperty("item_count")]		public int? ItemCount { get; set; }

		/// <summary>
		/// (Deprecated) Use `conforming_item_count`
		/// </summary>
		[JsonProperty("yes_item_count")]		public int? YesItemCount { get; set; }

		/// <summary>
		/// Checklist personal status
		/// </summary>
		[JsonProperty("personal")]		public bool Personal { get; set; }

		/// <summary>
		/// (Deprecated) Use `item_count`
		/// </summary>
		[JsonProperty("item_total")]		public int? ItemTotal { get; set; }

		/// <summary>
		/// Count of Checklist Items with a status of `yes`
		/// </summary>
		[JsonProperty("conforming_item_count")]		public int? ConformingItemCount { get; set; }

		/// <summary>
		/// Count of Checklist Items with a status of `no`
		/// </summary>
		[JsonProperty("deficient_item_count")]		public int? DeficientItemCount { get; set; }

		/// <summary>
		/// Count of Checklist Items with a status of `n/a`
		/// </summary>
		[JsonProperty("na_item_count")]		public int? NaItemCount { get; set; }

		/// <summary>
		/// Number of Checklist Items with a status of `neutral`
		/// </summary>
		[JsonProperty("neutral_item_count")]		public int? NeutralItemCount { get; set; }

		/// <summary>
		/// Count of Checklist Items that have not been inspected
		/// </summary>
		[JsonProperty("not_inspected_item_count")]		public int? NotInspectedItemCount { get; set; }

		/// <summary>
		/// Array of Drawing IDs
		/// </summary>
		[JsonProperty("drawing_ids")]		public DrawingIds[] DrawingIds { get; set; }

		/// <summary>
		/// Array of Current Drawing Revision IDs
		/// </summary>
		[JsonProperty("current_drawing_revision_ids")]		public CurrentDrawingRevisionIds[] CurrentDrawingRevisionIds { get; set; }

		/// <summary>
		/// Checklist attachments
		/// </summary>
		[JsonProperty("attachments")]		public Attachments[] Attachments { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("created_by")]		public CreatedBy CreatedBy { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("closed_by")]		public ClosedBy ClosedBy { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("location")]		public Location Location { get; set; }

		/// <summary>
		/// Specification Section
		/// </summary>
		[JsonProperty("specification_section")]		public SpecificationSection SpecificationSection { get; set; }

		/// <summary>
		/// Checklist signature requests
		/// </summary>
		[JsonProperty("signature_requests")]		public ChecklistSignatureRequest[] SignatureRequests { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("trade")]		public Trade Trade { get; set; }

		/// <summary>
		/// Users that will be performing the inspection
		/// </summary>
		[JsonProperty("inspectors")]		public Inspectors[] Inspectors { get; set; }

		/// <summary>
		/// Vendor responsible for the work being inspected
		/// </summary>
		[JsonProperty("responsible_contractor")]		public ResponsibleContractor ResponsibleContractor { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("responsible_party")]		public ResponsibleParty ResponsibleParty { get; set; }
	}
}
