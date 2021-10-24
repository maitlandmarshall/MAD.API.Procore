using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Endpoints.Incidents.Models
{
    public class Location
    {

        /// <summary>
        /// Location ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Location name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Location node name
        /// </summary>
        [JsonProperty("node_name")] public string NodeName { get; set; }

        /// <summary>
        /// Location parent id
        /// </summary>
        [JsonProperty("parent_id")] public long? ParentId { get; set; }

        /// <summary>
        /// Timestamp of Location creation
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of last update to Location
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
    }
}
