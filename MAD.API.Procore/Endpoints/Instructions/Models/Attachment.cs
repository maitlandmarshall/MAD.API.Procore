using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Instructions.Models
{
    public class Attachment
    {

        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Base name of the file without its path
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// URL to download the attached file. HTTP client should be prepared to follow redirects to successfully download the file.
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }
    }
}
