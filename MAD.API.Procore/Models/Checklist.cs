using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Checklist {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("list_template_id")]
		public int ListTemplateId { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("list_template_name")]
		public string ListTemplateName { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("distribution_members")]
		public JToken DistributionMembers { get; set; }
		[JsonProperty("due_at")]
		public DateTimeOffset DueAt { get; set; }
		[JsonProperty("number")]
		public int Number { get; set; }
		[JsonProperty("status")]
		public string Status { get; set; }
		[JsonProperty("inspection_date")]
		public string InspectionDate { get; set; }
		[JsonProperty("created_at")]
		public DateTimeOffset CreatedAt { get; set; }
		[JsonProperty("updated_at")]
		public DateTimeOffset UpdatedAt { get; set; }
		[JsonProperty("closed_at")]
		public DateTimeOffset ClosedAt { get; set; }
		[JsonProperty("item_count")]
		public int ItemCount { get; set; }
		[JsonProperty("yes_item_count")]
		public int YesItemCount { get; set; }
		[JsonProperty("personal")]
		public bool Personal { get; set; }
		[JsonProperty("item_total")]
		public int ItemTotal { get; set; }
		[JsonProperty("conforming_item_count")]
		public int ConformingItemCount { get; set; }
		[JsonProperty("deficient_item_count")]
		public int DeficientItemCount { get; set; }
		[JsonProperty("na_item_count")]
		public int NaItemCount { get; set; }
		[JsonProperty("neutral_item_count")]
		public int NeutralItemCount { get; set; }
		[JsonProperty("not_inspected_item_count")]
		public int NotInspectedItemCount { get; set; }
		[JsonProperty("drawing_ids")]
		public JToken DrawingIds { get; set; }
		[JsonProperty("current_drawing_revision_ids")]
		public JToken CurrentDrawingRevisionIds { get; set; }
		[JsonProperty("attachments")]
		public JToken Attachments { get; set; }
		[JsonProperty("created_by")]
		public JToken CreatedBy { get; set; }
		[JsonProperty("closed_by")]
		public JToken ClosedBy { get; set; }
		[JsonProperty("location")]
		public Location Location { get; set; }
		[JsonProperty("specification_section")]
		public JToken SpecificationSection { get; set; }
		[JsonProperty("signature_requests")]
		public ChecklistSignatureRequest[] SignatureRequests { get; set; }
		[JsonProperty("trade")]
		public Trade Trade { get; set; }
		[JsonProperty("inspectors")]
		public JToken Inspectors { get; set; }
		[JsonProperty("responsible_contractor")]
		public JToken ResponsibleContractor { get; set; }
		[JsonProperty("responsible_party")]
		public JToken ResponsibleParty { get; set; }
	}
}
