using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Checklist {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Checklist Template ID from which this Checklist was created
		/// </summary>
		[JsonProperty("list_template_id")]	public  int? ListTemplateId { get ; set; }

		/// <summary>
		/// Current name of the Checklist Template from which this Checklist was created
		/// </summary>
		[JsonProperty("list_template_name")]	public  int? ListTemplateName { get ; set; }

		/// <summary>
		/// Number
		/// </summary>
		[JsonProperty("number")]	public  int? Number { get ; set; }

		/// <summary>
		/// Status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		[JsonProperty("location")]	public  Location Location { get ; set; }

		/// <summary>
		/// Timestamp of creation
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
		/// Description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Indicates whether this Checklist has been deleted
		/// </summary>
		[JsonProperty("deleted")]	public  bool Deleted { get ; set; }

		/// <summary>
		/// Timestamp indicating when the Inspection is due
		/// </summary>
		[JsonProperty("due_at")]	public  DateTimeOffset? DueAt { get ; set; }

		/// <summary>
		/// Date that the inspection was performed
		/// </summary>
		[JsonProperty("inspection_date")]	public  string InspectionDate { get ; set; }

		[JsonProperty("inspection_type")]	public  InspectionType InspectionType { get ; set; }

		/// <summary>
		/// Indicates whether this Checklist is private
		/// </summary>
		[JsonProperty("private")]	public  bool Private { get ; set; }

		[JsonProperty("created_by")]	public  CreatedBy CreatedBy { get ; set; }

		[JsonProperty("closed_by")]	public  ClosedBy ClosedBy { get ; set; }

		/// <summary>
		/// Vendor responsible for the work being inspected
		/// </summary>
		[JsonProperty("responsible_contractor")]	public  ResponsibleContractor ResponsibleContractor { get ; set; }

		[JsonProperty("point_of_contact")]	public  PointOfContact PointOfContact { get ; set; }

		[JsonProperty("trade")]	public  Trade Trade { get ; set; }

		/// <summary>
		/// Inspectors
		/// </summary>
		[JsonProperty("inspectors")]	public  Inspectors[] Inspectors { get ; set; }

		/// <summary>
		/// Distribution Members
		/// </summary>
		[JsonProperty("distribution_members")]	public  DistributionMembers[] DistributionMembers { get ; set; }

		/// <summary>
		/// Checklist Signature Requests
		/// </summary>
		[JsonProperty("signature_requests")]	public  ChecklistSignatureRequest[] SignatureRequests { get ; set; }

		/// <summary>
		/// Managed Equipment ID
		/// </summary>
		[JsonProperty("managed_equipment_id")]	public  int? ManagedEquipmentId { get ; set; }

		/// <summary>
		/// Specification Section
		/// </summary>
		[JsonProperty("specification_section")]	public  SpecificationSection SpecificationSection { get ; set; }

		/// <summary>
		/// Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  ChecklistInspectionAttachment[] Attachments { get ; set; }

		/// <summary>
		/// Number of Checklist Items with a status of `yes`
		/// </summary>
		[JsonProperty("conforming_item_count")]	public  int? ConformingItemCount { get ; set; }

		/// <summary>
		/// Number of Checklist Items with a status of `no`
		/// </summary>
		[JsonProperty("deficient_item_count")]	public  int? DeficientItemCount { get ; set; }

		/// <summary>
		/// Number of Checklist Items with a status of `n/a`
		/// </summary>
		[JsonProperty("not_applicable_item_count")]	public  int? NotApplicableItemCount { get ; set; }

		/// <summary>
		/// Number of Checklist Items with a status of `neutral`
		/// </summary>
		[JsonProperty("neutral_item_count")]	public  int? NeutralItemCount { get ; set; }

		/// <summary>
		/// Number of Checklist Items that have been inspected
		/// </summary>
		[JsonProperty("inspected_item_count")]	public  int? InspectedItemCount { get ; set; }

		/// <summary>
		/// Number of Observations from this Checklist
		/// </summary>
		[JsonProperty("observations_count")]	public  int? ObservationsCount { get ; set; }

		/// <summary>
		/// Number of closed Observations pertaining to the Checklist
		/// </summary>
		[JsonProperty("closed_observations_count")]	public  int? ClosedObservationsCount { get ; set; }

		/// <summary>
		/// Number of Checklist Items within the Checklist
		/// </summary>
		[JsonProperty("item_count")]	public  int? ItemCount { get ; set; }
	}
}
