using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Models
{
    public class Comment
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Comment body
        /// </summary>
        [JsonProperty("body")] public string Body { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }
    }
}
