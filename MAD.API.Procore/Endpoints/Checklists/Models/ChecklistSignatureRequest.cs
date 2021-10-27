using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ChecklistSignatureRequest {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("signatory")]	public  Signatory Signatory { get ; set; }

		[JsonProperty("signature")]	public  ChecklistSignature Signature { get ; set; }
	}
}
