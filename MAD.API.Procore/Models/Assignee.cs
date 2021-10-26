using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class Assignee
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

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
