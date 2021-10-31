using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class Checklist {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("inspection_type")]	public  InspectionType InspectionType { get ; set; }

		/// <summary>
		/// Checklist Template ID
		/// </summary>
		[JsonProperty("list_template_id")]	public  long? ListTemplateId { get ; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Users on the Inspection distribution list
		/// </summary>
		[JsonProperty("distribution_members")]	public  List<ChecklistDistributionMember> DistributionMembers { get ; set; }

		/// <summary>
		/// Timestamp indicating when the Inspection is due
		/// </summary>
		[JsonProperty("due_at")]	public  DateTimeOffset? DueAt { get ; set; }

		/// <summary>
		/// Number
		/// </summary>
		[JsonProperty("number")]	public  int? Number { get ; set; }

		/// <summary>
		/// Status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Date that the inspection was performed
		/// </summary>
		[JsonProperty("inspection_date")]	public  string InspectionDate { get ; set; }

		/// <summary>
		/// Timestamp of inspection creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// Timestamp of when inspection was closed
		/// </summary>
		[JsonProperty("closed_at")]	public  DateTimeOffset? ClosedAt { get ; set; }

		/// <summary>
		/// Checklist Item count
		/// </summary>
		[JsonProperty("item_count")]	public  int? ItemCount { get ; set; }

		/// <summary>
		/// Deprecated. Use `conforming_item_count`
		/// </summary>
		[JsonProperty("yes_item_count")]	public  int? YesItemCount { get ; set; }

		/// <summary>
		/// Privacy status
		/// </summary>
		[JsonProperty("personal")]	public  bool Personal { get ; set; }

		/// <summary>
		/// (Deprecated) Use `item_count`
		/// </summary>
		[JsonProperty("item_total")]	public  int? ItemTotal { get ; set; }

		/// <summary>
		/// Count of Checklist Items with a status of `yes`
		/// </summary>
		[JsonProperty("conforming_item_count")]	public  int? ConformingItemCount { get ; set; }

		/// <summary>
		/// Count of Checklist Items with a status of `no`
		/// </summary>
		[JsonProperty("deficient_item_count")]	public  int? DeficientItemCount { get ; set; }

		/// <summary>
		/// Count of Checklist Items with a status of `n/a`
		/// </summary>
		[JsonProperty("na_item_count")]	public  int? NaItemCount { get ; set; }

		/// <summary>
		/// Number of Checklist Items with a status of `neutral`
		/// </summary>
		[JsonProperty("neutral_item_count")]	public  int? NeutralItemCount { get ; set; }

		/// <summary>
		/// Count of Checklist Items that have not been inspected
		/// </summary>
		[JsonProperty("not_inspected_item_count")]	public  int? NotInspectedItemCount { get ; set; }

		/// <summary>
		/// Array of Drawing IDs
		/// </summary>
		[JsonProperty("drawing_ids")]	public  List<long> DrawingIds { get ; set; }

		/// <summary>
		/// Array of Current Drawing Revision IDs
		/// </summary>
		[JsonProperty("current_drawing_revision_ids")]	public  List<long> CurrentDrawingRevisionIds { get ; set; }

		[JsonProperty("location")]	public  Location Location { get ; set; }

		/// <summary>
		/// Specification Section
		/// </summary>
		[JsonProperty("specification_section")]	public  ChecklistSpecificationSection SpecificationSection { get ; set; }

		[JsonProperty("trade")]	public  Trade Trade { get ; set; }

		[JsonProperty("created_by")]	public  ChecklistCreatedBy CreatedBy { get ; set; }

		[JsonProperty("closed_by")]	public  ChecklistClosedBy ClosedBy { get ; set; }

		/// <summary>
		/// Checklist inspectors
		/// </summary>
		[JsonProperty("inspectors")]	public  List<ChecklistInspector> Inspectors { get ; set; }

		/// <summary>
		/// Checklist signature requests
		/// </summary>
		[JsonProperty("signature_requests")]	public  List<ChecklistSignatureRequest> SignatureRequests { get ; set; }

		/// <summary>
		/// Vendor responsible for the work being inspected
		/// </summary>
		[JsonProperty("responsible_contractor")]	public  ChecklistResponsibleContractor ResponsibleContractor { get ; set; }

		[JsonProperty("responsible_party")]	public  ChecklistResponsibleParty ResponsibleParty { get ; set; }

		[JsonProperty("response_set")]	public  ChecklistDefaultResponseSet ResponseSet { get ; set; }

		/// <summary>
		/// Checklist Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<ChecklistAttachment> Attachments { get ; set; }

		/// <summary>
		/// Checklist Sections
		/// </summary>
		[JsonProperty("sections")]	public  List<ChecklistSection> Sections { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }

		/// <summary>
		/// Managed Equipment ID
		/// </summary>
		[JsonProperty("managed_equipment_id")]	public  long? ManagedEquipmentId { get ; set; }

		/// <summary>
		/// Template ID
		/// </summary>
		[JsonProperty("template_id")]	public  long? TemplateId { get ; set; }

		/// <summary>
		/// List Template Name
		/// </summary>
		[JsonProperty("list_template_name")]	public  string ListTemplateName { get ; set; }

		/// <summary>
		/// Trade ID
		/// </summary>
		[JsonProperty("trade_id")]	public  long? TradeId { get ; set; }

		/// <summary>
		/// Inspection Type ID
		/// </summary>
		[JsonProperty("inspection_type_id")]	public  long? InspectionTypeId { get ; set; }
	}
}
