using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Correspondences.Models
{
    public class GenericTool
    {
        /// <summary>
        /// Unique identifier for the generic tool.
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Primary name/title for the generic tool.
        /// </summary>
        [JsonProperty("title")] public string Title { get; set; }
    }
}
