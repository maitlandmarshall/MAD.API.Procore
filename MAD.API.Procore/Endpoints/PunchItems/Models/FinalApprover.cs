using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.PunchItems.Models
{
    public class FinalApprover
    {

        /// <summary>
        /// Login Information ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// User dictionary
        /// </summary>
        [JsonProperty("locale")] public string Locale { get; set; }
    }
}
