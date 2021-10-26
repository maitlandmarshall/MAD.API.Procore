using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class SpecificationSection
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")] public string Description { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [JsonProperty("section")] public string Section { get; set; }

        /// <summary>
        /// Url to PDF view
        /// </summary>
        [JsonProperty("latest_revision_url")] public string LatestRevisionUrl { get; set; }
    }
}
