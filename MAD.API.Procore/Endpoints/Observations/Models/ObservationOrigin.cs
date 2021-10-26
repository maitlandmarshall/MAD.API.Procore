using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Observations.Models
{
    public class ObservationOrigin
    {

        /// <summary>
        /// Origin Type
        /// </summary>
        [JsonProperty("type")] public string Type { get; set; }

        /// <summary>
        /// Payload Keys change depending on origin.
        /// </summary>
        [JsonProperty("payload")] public OriginPayload Payload { get; set; }
    }
}
