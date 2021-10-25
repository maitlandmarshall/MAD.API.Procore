using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using MAD.API.Procore.Models;

namespace MAD.API.Procore.Endpoints.Submittals.Models
{
    public class Submittal
    {

        [JsonProperty("actual_delivery_date")] public string ActualDeliveryDate { get; set; }

        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }

        [JsonProperty("confirmed_delivery_date")] public string ConfirmedDeliveryDate { get; set; }

        [JsonProperty("cost_code")] public CostCode CostCode { get; set; }

        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("custom_textarea_1")] public string CustomTextarea1 { get; set; }

        [JsonProperty("custom_textfield_1")] public string CustomTextfield1 { get; set; }

        /// <summary>
        /// *This field only displays on deleted items
        /// </summary>
        [JsonProperty("deleted_at")] public DateTimeOffset? DeletedAt { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("design_team_review_time")] public int? DesignTeamReviewTime { get; set; }

        [JsonProperty("distribution_members")] public List<DistributionMember> DistributionMembers { get; set; }

        [JsonProperty("internal_review_time")] public int? InternalReviewTime { get; set; }

        [JsonProperty("lead_time")] public int? LeadTime { get; set; }

        [JsonProperty("required_on_site_date")] public string RequiredOnSiteDate { get; set; }

        [JsonProperty("scheduled_task")] public Task ScheduledTask { get; set; }

        [JsonProperty("source_submittal_log_id")] public long? SourceSubmittalLogId { get; set; }

        [JsonProperty("distributed_submittals")] public List<DistributedSubmittal> DistributedSubmittals { get; set; }

        [JsonProperty("approvers")] public List<Approver> Approvers { get; set; }

        [JsonProperty("attachments_count")] public int? AttachmentsCount { get; set; }

        [JsonProperty("ball_in_court")] public List<BallInCourt> BallInCourt { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        [JsonProperty("current_revision")] public bool CurrentRevision { get; set; }

        [JsonProperty("distributed_at")] public DateTimeOffset? DistributedAt { get; set; }

        [JsonProperty("due_date")] public string DueDate { get; set; }

        [JsonProperty("formatted_number")] public string FormattedNumber { get; set; }

        [JsonProperty("issue_date")] public string IssueDate { get; set; }

        [JsonProperty("private")] public bool Private { get; set; }

        [JsonProperty("received_date")] public string ReceivedDate { get; set; }

        [JsonProperty("received_from")] public ReceivedFrom ReceivedFrom { get; set; }

        [JsonProperty("responsible_contractor")] public ResponsibleContractor ResponsibleContractor { get; set; }

        [JsonProperty("specification_section")] public SpecificationSection SpecificationSection { get; set; }

        [JsonProperty("sub_job")] public SubJob SubJob { get; set; }

        [JsonProperty("submit_by")] public string SubmitBy { get; set; }

        [JsonProperty("status")] public Status Status { get; set; }

        [JsonProperty("type")] public Procore.Models.Type Type { get; set; }

        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("submittal_manager")] public SubmittalManager SubmittalManager { get; set; }

        [JsonProperty("submittal_package")] public SubmittalPackage SubmittalPackage { get; set; }

        [JsonProperty("location")] public Location Location { get; set; }

        [JsonProperty("open_date")] public string OpenDate { get; set; }

        [JsonProperty("custom_fields")] public JObject CustomFields { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("number")] public string Number { get; set; }

        [JsonProperty("revision")] public string Revision { get; set; }

        [JsonProperty("title")] public string Title { get; set; }
    }
}
