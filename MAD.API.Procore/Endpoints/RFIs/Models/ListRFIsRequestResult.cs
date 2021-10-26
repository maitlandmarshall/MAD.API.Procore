using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.RFIs.Models
{
    public class ListRFIsRequestResult
    {

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Web link to resource
        /// </summary>
        [JsonProperty("link")] public string Link { get; set; }

        /// <summary>
        /// ID of the associated Location
        /// </summary>
        [JsonProperty("location_id")] public long? LocationId { get; set; }

        /// <summary>
        /// RFI Questions
        /// </summary>
        [JsonProperty("questions")] public List<Question> Questions { get; set; }

        [JsonProperty("custom_fields")] public JObject CustomFields { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("assignee")] public Assignee Assignee { get; set; }

        /// <summary>
        /// RFI Assignees
        /// </summary>
        [JsonProperty("assignees")] public List<Assignee> Assignees { get; set; }

        [JsonProperty("ball_in_court")] public BallInCourt BallInCourt { get; set; }

        /// <summary>
        /// Ball In Courts
        /// </summary>
        [JsonProperty("ball_in_courts")] public List<BallInCourt> BallInCourts { get; set; }

        [JsonProperty("cost_code")] public CostCode CostCode { get; set; }

        [JsonProperty("cost_impact")] public CostImpact CostImpact { get; set; }

        /// <summary>
        /// Date created
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Deleted status (this is only shown on deleted records)
        /// </summary>
        [JsonProperty("deleted")] public bool Deleted { get; set; }

        /// <summary>
        /// Time deleted (this is only shown on deleted records)
        /// </summary>
        [JsonProperty("deleted_at")] public DateTimeOffset? DeletedAt { get; set; }

        /// <summary>
        /// Due Date
        /// </summary>
        [JsonProperty("due_date")] public string DueDate { get; set; }

        /// <summary>
        /// Date initiated
        /// </summary>
        [JsonProperty("initiated_at")] public DateTimeOffset? InitiatedAt { get; set; }

        [JsonProperty("location")] public Location Location { get; set; }

        /// <summary>
        /// Full Number
        /// </summary>
        [JsonProperty("full_number")] public string FullNumber { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [JsonProperty("number")] public string Number { get; set; }

        /// <summary>
        /// Prefix
        /// </summary>
        [JsonProperty("prefix")] public string Prefix { get; set; }

        /// <summary>
        /// Private Status
        /// </summary>
        [JsonProperty("private")] public bool Private { get; set; }

        [JsonProperty("received_from")] public ReceivedFrom ReceivedFrom { get; set; }

        /// <summary>
        /// Reference
        /// </summary>
        [JsonProperty("reference")] public string Reference { get; set; }

        [JsonProperty("responsible_contractor")] public ResponsibleContractor ResponsibleContractor { get; set; }

        [JsonProperty("rfi_manager")] public RfiManager RfiManager { get; set; }

        [JsonProperty("schedule_impact")] public ScheduleImpact ScheduleImpact { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// Translated RFI status
        /// </summary>
        [JsonProperty("translated_status")] public string TranslatedStatus { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        [JsonProperty("subject")] public string Subject { get; set; }

        /// <summary>
        /// Time RFI was closed
        /// </summary>
        [JsonProperty("time_resolved")] public DateTimeOffset? TimeResolved { get; set; }

        /// <summary>
        /// Updated at
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
    }
}
