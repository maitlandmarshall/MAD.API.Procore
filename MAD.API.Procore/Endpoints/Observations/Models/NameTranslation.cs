using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Observations.Models
{
    public class NameTranslation
    {

        /// <summary>
        /// Company default value for commissioning observation type assuming company locale to be en
        /// </summary>
        [JsonProperty("en")] public string En { get; set; }

        /// <summary>
        /// Company custom translation for commissioning observation type
        /// </summary>
        [JsonProperty("es")] public string Es { get; set; }

        /// <summary>
        /// Company custom translation for commissioning observation type
        /// </summary>
        [JsonProperty("fr-CA")] public string FrCA { get; set; }

        /// <summary>
        /// Company custom translation for commissioning observation type
        /// </summary>
        [JsonProperty("en-AU")] public string EnAU { get; set; }
    }
}
