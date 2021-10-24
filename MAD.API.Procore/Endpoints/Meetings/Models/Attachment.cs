using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Meetings.Models
{
    public class Attachment
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        [JsonProperty("filename")] public string Filename { get; set; }
    }
}
