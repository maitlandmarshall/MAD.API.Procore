using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class Recipient
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

        /// <summary>
        /// User's Company Name
        /// </summary>
        [JsonProperty("company_name")] public string CompanyName { get; set; }
    }
}