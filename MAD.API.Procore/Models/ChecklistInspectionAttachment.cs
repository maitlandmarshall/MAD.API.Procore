using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class ChecklistInspectionAttachment
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("thumbnail_url")] public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Filename (deprecated)
        /// </summary>
        [JsonProperty("filename")] public string Filename { get; set; }

        [JsonProperty("content_type")] public string ContentType { get; set; }
    }
}
