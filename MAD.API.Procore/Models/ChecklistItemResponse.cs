using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistItemResponse {

		/// <summary>
		/// Item ID
		/// </summary>
		[JsonProperty("item_id")]		public int? ItemId { get; set; }

		/// <summary>
		/// Item Status
		/// </summary>
		[JsonProperty("status")]		public string Status { get; set; }

		/// <summary>
		/// Timestamp indicating when Response was added
		/// </summary>
		[JsonProperty("responded_at")]		public DateTimeOffset? RespondedAt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("responder")]		public Responder Responder { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("item_type")]		public ChecklistItemType ItemType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("payload")]		public Payload Payload { get; set; }
	}
}
