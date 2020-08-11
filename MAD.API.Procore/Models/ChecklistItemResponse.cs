using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistItemResponse {

		/// <summary>
		/// Item ID
		/// </summary>
		[JsonProperty("item_id")]	public  int ItemId { get ; set; }

		/// <summary>
		/// Item Status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Timestamp indicating when Response was added
		/// </summary>
		[JsonProperty("responded_at")]	public  DateTimeOffset? RespondedAt { get ; set; }

		[JsonProperty("responder")]	public  Responder Responder { get ; set; }

		[JsonProperty("item_type")]	public  ChecklistItemType ItemType { get ; set; }

		[JsonProperty("payload")]	public  Payload Payload { get ; set; }

		/// <summary>
		/// Response for an Open Ended Text Item
		/// </summary>
		public string PayloadTextValue
        {
			get => this.Payload?.TextValue;
			set
            {
				this.Payload.TextValue = value;
            }
        }

		/// <summary>
		/// Response for an Open Ended Number Item
		/// </summary>
		public int? PayloadNumberValue
        {
			get => this.Payload?.NumberValue;
			set
            {
				this.Payload.NumberValue = value;
            }
        }

		/// <summary>
		/// Response for an Open Ended Date Item
		/// </summary>
		public string PayloadDateValue
        {
			get => this.Payload?.DateValue;
			set
            {
				this.Payload.DateValue = value;
            }
        }

		public ResponseOption PayloadResponseOption
        {
			get => this.Payload?.ResponseOption;
			set
            {
				this.Payload.ResponseOption = value;
            }
        }

		/// <summary>
		/// Response for an Open Ended Text Item
		/// </summary>
		[JsonProperty("text_value")] public string TextValue { get; set; }

		/// <summary>
		/// Response for an Open Ended Number Item
		/// </summary>
		[JsonProperty("number_value")] public int? NumberValue { get; set; }

		/// <summary>
		/// Response for an Open Ended Date Item
		/// </summary>
		[JsonProperty("date_value")] public string DateValue { get; set; }

		[JsonProperty("response_option")] public ResponseOption ResponseOption { get; set; }
	}
}
