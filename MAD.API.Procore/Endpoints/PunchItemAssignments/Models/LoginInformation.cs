using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.PunchItemAssignments.Models
{
    public class LoginInformation
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

        /// <summary>
        /// Company Name
        /// </summary>
        [JsonProperty("company_name")] public string CompanyName { get; set; }
    }
}
