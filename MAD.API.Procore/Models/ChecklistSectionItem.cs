using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistSectionItem {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

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
		[JsonProperty("origin_id")]	public  int? OriginId { get ; set; }

		/// <summary>
		/// Checklist Section ID
		/// </summary>
		[JsonProperty("section_id")]	public  int? SectionId { get ; set; }

		/// <summary>
		/// Position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		/// <summary>
		/// Observations created from the Checklist Item
		/// </summary>
		[JsonProperty("observations")]	public  List<Observation> Observations { get ; set; }

		/// <summary>
		/// Item attachment histories
		/// </summary>
		[JsonProperty("attachment_histories")]	public  List<AttachmentHistory> AttachmentHistories { get ; set; }

		/// <summary>
		/// Item histories
		/// </summary>
		[JsonProperty("histories")]	public  List<History> Histories { get ; set; }

		/// <summary>
		/// Item Response
		/// </summary>
		[JsonProperty("item_response")]	public  ChecklistItemResponse ItemResponse { get ; set; }

		/// <summary>
		/// Item comments
		/// </summary>
		[JsonProperty("comments")]	public  List<Comment> Comments { get ; set; }

		[JsonProperty("response")]	public  ChecklistResponse Response { get ; set; }

		[JsonProperty("response_set")]	public  ResponseSet ResponseSet { get ; set; }

		[JsonProperty("type")]	public  ChecklistItemType Type { get ; set; }
	}
}
