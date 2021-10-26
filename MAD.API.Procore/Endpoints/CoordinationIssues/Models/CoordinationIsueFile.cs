using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.CoordinationIssues.Models
{
    public class CoordinationIsueFile
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Name of the file to be associated a project for creating Coordination Issues
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Unique UUID associated with the file
        /// </summary>
        [JsonProperty("uuid")] public string Uuid { get; set; }
    }
}
