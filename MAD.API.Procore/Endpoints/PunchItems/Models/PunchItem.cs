using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.PunchItems.Models
{
    public class PunchItem
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Array of Users
        /// </summary>
        [JsonProperty("ball_in_court")] public List<LoginInformation> BallInCourt { get; set; }

        /// <summary>
        /// Cost impact status
        /// </summary>
        [JsonProperty("cost_impact")] public string CostImpact { get; set; }

        /// <summary>
        /// Cost impact amount
        /// </summary>
        [JsonProperty("cost_impact_amount")] public string CostImpactAmount { get; set; }

        /// <summary>
        /// Created at
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Deleted at
        /// </summary>
        [JsonProperty("deleted_at")] public DateTimeOffset? DeletedAt { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")] public string Description { get; set; }

        /// <summary>
        /// Due date
        /// </summary>
        [JsonProperty("due_date")] public string DueDate { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Used to create a reference point between a Punch Item within Procore and a corresponding Punch Item outside of Procore
        /// </summary>
        [JsonProperty("reference")] public string Reference { get; set; }

        /// <summary>
        /// Assessed risk level of on-time completion
        /// </summary>
        [JsonProperty("schedule_risk")] public string ScheduleRisk { get; set; }

        /// <summary>
        /// Schedule impact status
        /// </summary>
        [JsonProperty("schedule_impact")] public string ScheduleImpact { get; set; }

        /// <summary>
        /// Schedule impact value in days
        /// </summary>
        [JsonProperty("schedule_impact_days")] public int? ScheduleImpactDays { get; set; }

        /// <summary>
        /// Reason for assessed risk level of on-time completion
        /// </summary>
        [JsonProperty("schedule_risk_reason")] public string ScheduleRiskReason { get; set; }

        /// <summary>
        /// Confidence of schedule risk assessment
        /// </summary>
        [JsonProperty("schedule_risk_confidence")] public int? ScheduleRiskConfidence { get; set; }

        /// <summary>
        /// Probability of schedule risk assessment
        /// </summary>
        [JsonProperty("schedule_risk_probability")] public int? ScheduleRiskProbability { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        [JsonProperty("position")] public int? Position { get; set; }

        /// <summary>
        /// Punch item priority - 'low', 'medium', 'high'
        /// </summary>
        [JsonProperty("priority")] public string Priority { get; set; }

        /// <summary>
        /// Privacy status
        /// </summary>
        [JsonProperty("private")] public bool Private { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// At least one Punch Item Assignment has a status of 'resolved
        /// </summary>
        [JsonProperty("has_resolved_responses")] public bool HasResolvedResponses { get; set; }

        /// <summary>
        /// At least one Punch Item Assignment has a status of 'unresolved'
        /// </summary>
        [JsonProperty("has_unresolved_responses")] public bool HasUnresolvedResponses { get; set; }

        /// <summary>
        /// Updated at
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("location")] public Location Location { get; set; }

        [JsonProperty("trade")] public Trade Trade { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Login Information
        /// </summary>
        [JsonProperty("punch_item_manager")] public PunchItemManager PunchItemManager { get; set; }

        /// <summary>
        /// Login Information
        /// </summary>
        [JsonProperty("final_approver")] public FinalApprover FinalApprover { get; set; }

        [JsonProperty("punch_item_type")] public PunchItemType PunchItemType { get; set; }

        [JsonProperty("cost_code")] public CostCode CostCode { get; set; }

        /// <summary>
        /// Array of Punch Item Assignments
        /// </summary>
        [JsonProperty("assignments")] public List<Assignment> Assignments { get; set; }

        /// <summary>
        /// Punch Item Assignees
        /// </summary>
        [JsonProperty("assignees")] public List<Assignee> Assignees { get; set; }

        /// <summary>
        /// Latitude of Punch Item
        /// </summary>
        [JsonProperty("latitude")] public string Latitude { get; set; }

        /// <summary>
        /// Longitude of Punch Item
        /// </summary>
        [JsonProperty("longitude")] public string Longitude { get; set; }

        /// <summary>
        /// Horizontal Accuracy of Punch Item
        /// </summary>
        [JsonProperty("horizontal_accuracy")] public string HorizontalAccuracy { get; set; }

        /// <summary>
        /// Vertical Accuracy of Punch Item
        /// </summary>
        [JsonProperty("vertical_accuracy")] public string VerticalAccuracy { get; set; }

        /// <summary>
        /// Altitude of Punch Item
        /// </summary>
        [JsonProperty("altitude")] public string Altitude { get; set; }

        /// <summary>
        /// Workflow status of the Punch Item
        /// </summary>
        [JsonProperty("workflow_status")] public string WorkflowStatus { get; set; }

        [JsonProperty("custom_fields")] public JObject CustomFields { get; set; }
    }
}
