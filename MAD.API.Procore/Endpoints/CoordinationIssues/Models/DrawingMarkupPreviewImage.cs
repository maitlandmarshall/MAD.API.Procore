using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.CoordinationIssues.Models
{
    public class DrawingMarkupPreviewImage
    {

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("drawing_revision_id")] public long? DrawingRevisionId { get; set; }

        /// <summary>
        /// Base name of the file without its path
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// A mime type or a file extension
        /// </summary>
        [JsonProperty("content_type")] public string ContentType { get; set; }

        /// <summary>
        /// URL to download the attached file. HTTP client should be prepared to follow redirects to successfully download the file.
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }
    }
}