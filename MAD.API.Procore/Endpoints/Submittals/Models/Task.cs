using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Submittals.Models
{
    public class Task
    {

        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Task name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// A deprecated value which was originally used to uniquely identify tasks.
        /// This value will be removed in a later version of the API.
        /// </summary>
        [JsonProperty("key")] public string Key { get; set; }
    }
}
