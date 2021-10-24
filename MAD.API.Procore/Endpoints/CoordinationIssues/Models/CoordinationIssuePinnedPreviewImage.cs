using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.CoordinationIssues.Models
{
    public class CoordinationIssuePinnedPreviewImage
    {

        /// <summary>
        /// Drawing ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Formatted title of the drawing
        /// </summary>
        [JsonProperty("title")] public string Title { get; set; }

        /// <summary>
        /// Procore Web App URL of the drawing
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }
    }
}
