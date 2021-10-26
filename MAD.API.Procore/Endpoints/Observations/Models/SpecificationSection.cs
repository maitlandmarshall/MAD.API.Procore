using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Observations.Models
{
    public class SpecificationSection
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")] public string Description { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [JsonProperty("number")] public string Number { get; set; }

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
