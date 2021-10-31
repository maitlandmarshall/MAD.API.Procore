using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ChecklistSectionItemAttachment {

		/// <summary>
		/// Attachment ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		[JsonProperty("created_by")]	public  ChecklistSectionItemAttachmentCreatedBy CreatedBy { get ; set; }

		[JsonProperty("attachment")]	public  ChecklistSectionItemAttachmentAttachment Attachment { get ; set; }
	}
}
