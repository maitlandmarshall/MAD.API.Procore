using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.PunchItems.Models
{
    public class PunchItemType
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
