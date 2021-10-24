using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Schedule.Models
{
    public class Type
    {

        /// <summary>
        /// Schedule type key
        /// </summary>
        [JsonProperty("key")] public string Key { get; set; }

        /// <summary>
        /// Schedule type Primavera P6 Identifier
        /// </summary>
        [JsonProperty("p6_id")] public string P6Id { get; set; }
    }
}
