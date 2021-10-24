using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.CoordinationIssues.Models
{
    public class DrawingRevision
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Formatted title of the drawing revision
        /// </summary>
        [JsonProperty("title")] public string Title { get; set; }
    }
}
