using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.BIMModels.Models
{
    public class MaxBoundary
    {

        /// <summary>
        /// x-axis coordinate
        /// </summary>
        [JsonProperty("x")] public decimal? X { get; set; }

        /// <summary>
        /// y-axis coordinate
        /// </summary>
        [JsonProperty("y")] public decimal? Y { get; set; }

        /// <summary>
        /// z-axis coordinate
        /// </summary>
        [JsonProperty("z")] public decimal? Z { get; set; }
    }
}
