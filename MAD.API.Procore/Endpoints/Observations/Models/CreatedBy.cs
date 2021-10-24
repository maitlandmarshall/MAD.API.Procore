using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Observations.Models
{
    public class CreatedBy
    {

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
