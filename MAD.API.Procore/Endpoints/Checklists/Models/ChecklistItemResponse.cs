using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ChecklistItemResponse {

		/// <summary>
		/// Item ID
		/// </summary>
		[JsonProperty("item_id")]	public  long? ItemId { get ; set; }

		/// <summary>
		/// Item Status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Timestamp indicating when Response was added
		/// </summary>
		[JsonProperty("responded_at")]	public  DateTimeOffset? RespondedAt { get ; set; }

		[JsonProperty("responder")]	public  ChecklistItemResponseResponder Responder { get ; set; }

		[JsonProperty("item_type")]	public  ChecklistItemType ItemType { get ; set; }

		[JsonProperty("payload")]	public  ChecklistItemResponsePayload Payload { get ; set; }
	}
}
