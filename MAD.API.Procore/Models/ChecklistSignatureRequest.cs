using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistSignatureRequest {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("signatory")]
		public JToken Signatory { get; set; }
		[JsonProperty("signature")]
		public ChecklistSignature Signature { get; set; }
	}
}
