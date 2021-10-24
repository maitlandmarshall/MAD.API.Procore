using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Models
{
    public class Observation
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [JsonProperty("number")] public string Number { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonProperty("title")] public string Title { get; set; }

        /// <summary>
        /// Observation Type
        /// </summary>
        [JsonProperty("type")] public Type Type { get; set; }

        [JsonProperty("assignee")] public Assignee Assignee { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }
    }
}
