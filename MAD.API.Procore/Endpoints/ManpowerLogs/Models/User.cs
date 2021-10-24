using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.ManpowerLogs.Models
{
    public class User
    {

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// User Login
        /// </summary>
        [JsonProperty("login")] public string Login { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
