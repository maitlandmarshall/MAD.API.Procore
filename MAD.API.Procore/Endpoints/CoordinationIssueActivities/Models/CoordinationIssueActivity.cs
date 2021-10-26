using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Endpoints.CoordinationIssueActivities.Models
{
    public class CoordinationIssueActivity
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Coordination Issue ID
        /// </summary>
        [JsonProperty("coordination_issue_id")] public decimal? CoordinationIssueId { get; set; }

        /// <summary>
        /// Activity Type.
        /// </summary>
        [JsonProperty("type")] public string Type { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Updated date
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
    }
}
