using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Endpoints.CoordinationIssueStatusChanges.Models
{
    public class CoordinationIssueStatusChange
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// ID of the parent Coordination Issue
        /// </summary>
        [JsonProperty("coordination_issue_id")] public long? CoordinationIssueId { get; set; }

        /// <summary>
        /// Value of the status prior to change
        /// </summary>
        [JsonProperty("old_status")] public string OldStatus { get; set; }

        /// <summary>
        /// Value of the status following the change
        /// </summary>
        [JsonProperty("new_status")] public string NewStatus { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// CoordinationIssue Procore Item Association details
        /// </summary>
        [JsonProperty("linked_rfi")] public LinkedRfi LinkedRfi { get; set; }

        /// <summary>
        /// CoordinationIssue linked Observation Item
        /// </summary>
        [JsonProperty("linked_observation_item")] public LinkedObservationItem LinkedObservationItem { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }
    }
}
