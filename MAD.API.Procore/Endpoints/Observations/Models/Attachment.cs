using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Observations.Models
{
    public class Attachment
    {

        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Use :name, :filename to be deprecated
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("url")] public string Url { get; set; }

        /// <summary>
        /// :filename to be deprecated, use :name
        /// </summary>
        [JsonProperty("filename")] public string Filename { get; set; }
    }
}
