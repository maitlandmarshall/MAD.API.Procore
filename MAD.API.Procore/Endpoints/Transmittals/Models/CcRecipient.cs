using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Transmittals.Models
{
    public class CcRecipient
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("login")] public string Login { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
