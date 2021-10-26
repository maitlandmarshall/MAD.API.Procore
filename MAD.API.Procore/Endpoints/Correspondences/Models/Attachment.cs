using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Correspondences.Models
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
        [JsonProperty("name")] public string Name { get; set; }
    }
}
