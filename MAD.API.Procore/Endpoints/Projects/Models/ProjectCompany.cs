using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Projects.Models
{
    public class ProjectCompany
    {
        /// <summary>
        /// Unique identifier for the company.
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// The Company name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
