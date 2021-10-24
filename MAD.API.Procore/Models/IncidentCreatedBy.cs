using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class IncidentCreatedBy
    {

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("login")] public string Login { get; set; }

        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}
