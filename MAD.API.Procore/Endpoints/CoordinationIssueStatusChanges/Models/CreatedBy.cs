using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.CoordinationIssueStatusChanges.Models
{
    public class CreatedBy
    {

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("login")] public string Login { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}
