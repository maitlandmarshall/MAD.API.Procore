using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Endpoints.PunchItemTypes.Models
{
    public class PunchItemType
    {

        /// <summary>
        /// Punch Item Type ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Punch Item Type name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Punch Item Type created at
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Punch Item Type last updated at
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
    }
}
