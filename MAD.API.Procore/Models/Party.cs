using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class Party
    {

        /// <summary>
        /// Timecard entry id
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Party Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
