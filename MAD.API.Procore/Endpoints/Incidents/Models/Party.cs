using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Incidents.Models
{
    public class Party
    {

        /// <summary>
        /// Timecard entry id
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Party Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
