using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Submittals.Models {
	public class ListSubmittalsOnAProjectRequestResultApprover {

		/// <summary>
		/// Role of Approver
		/// </summary>
		[JsonProperty("approver_type")]	public  string ApproverType { get ; set; }

		[JsonProperty("comment")]	public  string Comment { get ; set; }

		[JsonProperty("distributed")]	public  bool Distributed { get ; set; }

		[JsonProperty("response")]	public  ListSubmittalsOnAProjectRequestResultApproverResponse Response { get ; set; }

		/// <summary>
		/// Returned Date
		/// </summary>
		[JsonProperty("returned_date")]	public  string ReturnedDate { get ; set; }

		/// <summary>
		/// Sent Date
		/// </summary>
		[JsonProperty("sent_date")]	public  string SentDate { get ; set; }

		/// <summary>
		/// Due Date
		/// </summary>
		[JsonProperty("due_date")]	public  string DueDate { get ; set; }

		[JsonProperty("user")]	public  ListSubmittalsOnAProjectRequestResultApproverUser User { get ; set; }

		/// <summary>
		/// Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<ListSubmittalsOnAProjectRequestResultApproverAttachment> Attachments { get ; set; }

		/// <summary>
		/// Submittal Associated Attachment IDs
		/// </summary>
		[JsonProperty("submittal_associated_attachment_ids")]	public  List<long> SubmittalAssociatedAttachmentIds { get ; set; }

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }
	}
}
