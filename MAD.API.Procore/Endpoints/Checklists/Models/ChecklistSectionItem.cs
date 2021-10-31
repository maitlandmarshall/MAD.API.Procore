using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ChecklistSectionItem {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Details
		/// </summary>
		[JsonProperty("details")]	public  string Details { get ; set; }

		/// <summary>
		/// Status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Representation of an Item's Response
		/// </summary>
		[JsonProperty("responded_with")]	public  string RespondedWith { get ; set; }

		/// <summary>
		/// ID of Corresponding Checklist Template Item
		/// </summary>
		[JsonProperty("origin_id")]	public  long? OriginId { get ; set; }

		/// <summary>
		/// Checklist Section ID
		/// </summary>
		[JsonProperty("section_id")]	public  long? SectionId { get ; set; }

		/// <summary>
		/// Position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		/// <summary>
		/// Observations created from the Checklist Item
		/// </summary>
		[JsonProperty("observations")]	public  List<ChecklistSectionItemObservation> Observations { get ; set; }

		/// <summary>
		/// Item attachment histories
		/// </summary>
		[JsonProperty("attachment_histories")]	public  List<ChecklistSectionItemAttachmentHistory> AttachmentHistories { get ; set; }

		/// <summary>
		/// Item attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<ChecklistSectionItemAttachment> Attachments { get ; set; }

		/// <summary>
		/// Item histories
		/// </summary>
		[JsonProperty("histories")]	public  List<ChecklistSectionItemHistory> Histories { get ; set; }

		/// <summary>
		/// Item Response
		/// </summary>
		[JsonProperty("item_response")]	public  ChecklistItemResponse ItemResponse { get ; set; }

		/// <summary>
		/// Item comments
		/// </summary>
		[JsonProperty("comments")]	public  List<ChecklistSectionItemComment> Comments { get ; set; }

		[JsonProperty("response")]	public  ChecklistResponse Response { get ; set; }

		[JsonProperty("response_set")]	public  ChecklistSectionItemResponseSet ResponseSet { get ; set; }

		[JsonProperty("type")]	public  ChecklistItemType Type { get ; set; }

		/// <summary>
		/// Response Set ID
		/// </summary>
		[JsonProperty("response_set_id")]	public  long? ResponseSetId { get ; set; }

		/// <summary>
		/// Template Item ID
		/// </summary>
		[JsonProperty("template_item_id")]	public  long? TemplateItemId { get ; set; }

		/// <summary>
		/// Response Type ID
		/// </summary>
		[JsonProperty("response_type_id")]	public  long? ResponseTypeId { get ; set; }
	}
}
