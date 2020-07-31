using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistSignatureRequest {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("signatory")]		public Signatory Signatory { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("signature")]		public ChecklistSignature Signature { get; set; }
	}
}
