using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Models
{
    public class ChecklistSignature
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("captured_by")] public CapturedBy CapturedBy { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        [JsonProperty("captured_at")] public DateTimeOffset? CapturedAt { get; set; }

        [JsonProperty("attachment")] public Attachment Attachment { get; set; }
    }
}
