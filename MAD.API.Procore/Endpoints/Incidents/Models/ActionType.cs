using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Endpoints.Incidents.Models
{
    public class ActionType
    {

        /// <summary>
        /// Incident Action Type ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Incident Action Type Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Represents whether an Incident Action Type is available for use.
        /// </summary>
        [JsonProperty("active")] public bool Active { get; set; }

        /// <summary>
        /// Represents whether an Incident Action Type has been provided by Procore.
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
