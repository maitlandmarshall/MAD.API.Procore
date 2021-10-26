using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.RFIs.Models
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
    }
}
