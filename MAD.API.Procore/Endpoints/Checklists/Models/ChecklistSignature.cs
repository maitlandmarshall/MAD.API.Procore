using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ChecklistSignature {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("captured_by")]	public  ChecklistSignatureCapturedBy CapturedBy { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("captured_at")]	public  DateTimeOffset? CapturedAt { get ; set; }

		[JsonProperty("attachment")]	public  ChecklistSignatureAttachment Attachment { get ; set; }
	}
}
