using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Endpoints.Observations.Models
{
    public class ContributingBehavior
    {

        /// <summary>
        /// Contributing Behavior ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Contributing Behavior Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Represents whether a Contributing Behavior is available for use.
        /// </summary>
        [JsonProperty("active")] public bool Active { get; set; }

        /// <summary>
        /// Represents whether a Contributing Behavior has been provided by Procore.
        /// </summary>
        [JsonProperty("global")] public bool Global { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of last update
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
    }
}
