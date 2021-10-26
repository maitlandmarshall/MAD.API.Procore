using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Instructions.Models
{
    public class CostImpact
    {

        /// <summary>
        /// Cost impact status
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// Cost impact value in dollars
        /// </summary>
        [JsonProperty("value")] public decimal? Value { get; set; }
    }
}
