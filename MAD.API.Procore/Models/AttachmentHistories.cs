using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class AttachmentHistory {

		/// <summary>
		/// Attachment ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		[JsonProperty("created_by")]	public  CreatedBy CreatedBy { get ; set; }

		[JsonProperty("attachment")]	public  Attachment Attachment { get ; set; }
	}
}
