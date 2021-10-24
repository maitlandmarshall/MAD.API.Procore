using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Endpoints.Incidents.Models
{
    public class BodyPart
    {

        /// <summary>
        /// Body Part ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Body Part Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Represents whether a Body Part can be associated to an injury.
        /// </summary>
        [JsonProperty("selectable")] public bool Selectable { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of last update
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Parent Body Part ID
        /// </summary>
        [JsonProperty("parent_id")] public long? ParentId { get; set; }
    }
}
