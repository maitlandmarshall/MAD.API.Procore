using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Submittals.Models {
	public class ShowSubmittalRequestResultDistributedSubmittal {

		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("message")]	public  string Message { get ; set; }

		[JsonProperty("sent_at")]	public  DateTimeOffset? SentAt { get ; set; }

		[JsonProperty("distributed_by")]	public  ShowSubmittalRequestResultDistributedSubmittalDistributedBy DistributedBy { get ; set; }

		[JsonProperty("distributed_to")]	public  List<ShowSubmittalRequestResultDistributedSubmittalDistributedTo> DistributedTo { get ; set; }

		[JsonProperty("final_attachments")]	public  List<ShowSubmittalRequestResultDistributedSubmittalFinalAttachment> FinalAttachments { get ; set; }

		/// <summary>
		/// List of Submittal Approver IDs for approvers selected to be distributed
		/// </summary>
		[JsonProperty("selected_approver_ids")]	public  List<long> SelectedApproverIds { get ; set; }
	}
}
