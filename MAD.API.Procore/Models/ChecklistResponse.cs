using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class ChecklistResponse
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// The name of the Response
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Corresponding Checklist Item status
        /// </summary>
        [JsonProperty("corresponding_status")] public string CorrespondingStatus { get; set; }
    }
}
