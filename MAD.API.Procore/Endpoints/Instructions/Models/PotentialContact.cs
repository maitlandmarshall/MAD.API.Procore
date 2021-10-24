using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Instructions.Models
{
    public class PotentialContact
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Does contact have specified access for project
        /// </summary>
        [JsonProperty("valid")] public bool Valid { get; set; }

        /// <summary>
        /// Full name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [JsonProperty("company_name")] public string CompanyName { get; set; }
    }
}
