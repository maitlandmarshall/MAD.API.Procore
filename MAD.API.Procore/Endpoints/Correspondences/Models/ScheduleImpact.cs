using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Correspondences.Models
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
        [JsonProperty("value")] public decimal? Value { get; set; }
    }
}
