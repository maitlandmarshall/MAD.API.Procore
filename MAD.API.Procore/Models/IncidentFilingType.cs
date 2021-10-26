using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Models
{
    public class IncidentFilingType
    {

        /// <summary>
        /// Incident Filing Type ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Incident Filing Type Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("severity_level")] public SeverityLevel SeverityLevel { get; set; }

        /// <summary>
        /// Timestamp of last update
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
    }
}
