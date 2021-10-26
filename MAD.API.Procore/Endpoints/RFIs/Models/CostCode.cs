using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.RFIs.Models
{
    public class CostCode
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
