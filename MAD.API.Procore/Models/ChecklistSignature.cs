using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistSignature {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("captured_by")]
		public JToken CapturedBy { get; set; }
		[JsonProperty("captured_at")]
		public DateTimeOffset CapturedAt { get; set; }
		[JsonProperty("attachment")]
		public JToken Attachment { get; set; }
	}
}
