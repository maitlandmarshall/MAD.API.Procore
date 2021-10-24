using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Instructions.Models
{
    public class ScheduleImpact
    {

        /// <summary>
        /// Schedule impact status
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// Schedule impact value
        /// </summary>
        [JsonProperty("value")] public int? Value { get; set; }
    }
}
