using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Incidents.Models
{
    public class AffectedPerson
    {

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("login")] public string Login { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}
