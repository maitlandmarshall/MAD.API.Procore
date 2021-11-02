using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Submittals.Models {
	public class ListSubmittalsOnAProjectRequestResult {

		[JsonProperty("approvers")]	public  List<ListSubmittalsOnAProjectRequestResultApprover> Approvers { get ; set; }

		[JsonProperty("attachments_count")]	public  int? AttachmentsCount { get ; set; }

		[JsonProperty("ball_in_court")]	public  List<ListSubmittalsOnAProjectRequestResultBallInCourt> BallInCourt { get ; set; }

		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		[JsonProperty("created_by")]	public  ListSubmittalsOnAProjectRequestResultCreatedBy CreatedBy { get ; set; }

		[JsonProperty("current_revision")]	public  bool CurrentRevision { get ; set; }

		[JsonProperty("distributed_at")]	public  DateTimeOffset? DistributedAt { get ; set; }

		[JsonProperty("due_date")]	public  string DueDate { get ; set; }

		[JsonProperty("formatted_number")]	public  string FormattedNumber { get ; set; }

		[JsonProperty("issue_date")]	public  string IssueDate { get ; set; }

		[JsonProperty("private")]	public  bool Private { get ; set; }

		[JsonProperty("received_date")]	public  string ReceivedDate { get ; set; }

		[JsonProperty("received_from")]	public  ListSubmittalsOnAProjectRequestResultReceivedFrom ReceivedFrom { get ; set; }

		[JsonProperty("responsible_contractor")]	public  ListSubmittalsOnAProjectRequestResultResponsibleContractor ResponsibleContractor { get ; set; }

		[JsonProperty("specification_section")]	public  ListSubmittalsOnAProjectRequestResultSpecificationSection SpecificationSection { get ; set; }

		[JsonProperty("sub_job")]	public  ListSubmittalsOnAProjectRequestResultSubJob SubJob { get ; set; }

		[JsonProperty("submit_by")]	public  string SubmitBy { get ; set; }

		[JsonProperty("status")]	public  ListSubmittalsOnAProjectRequestResultStatu Status { get ; set; }

		[JsonProperty("type")]	public  ListSubmittalsOnAProjectRequestResultType Type { get ; set; }

		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		[JsonProperty("submittal_manager")]	public  ListSubmittalsOnAProjectRequestResultSubmittalManager SubmittalManager { get ; set; }

		[JsonProperty("submittal_package")]	public  ListSubmittalsOnAProjectRequestResultSubmittalPackage SubmittalPackage { get ; set; }

		[JsonProperty("location")]	public  Location Location { get ; set; }

		[JsonProperty("open_date")]	public  string OpenDate { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }

		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("number")]	public  string Number { get ; set; }

		[JsonProperty("revision")]	public  string Revision { get ; set; }

		[JsonProperty("title")]	public  string Title { get ; set; }
	}
}
