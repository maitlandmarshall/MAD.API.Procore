using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistSignature {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("captured_by")]		public CapturedBy CapturedBy { get; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("captured_at")]		public DateTimeOffset? CapturedAt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("attachment")]		public Attachment Attachment { get; set; }
	}
}
