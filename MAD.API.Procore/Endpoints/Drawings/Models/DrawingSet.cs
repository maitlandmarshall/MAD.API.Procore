using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Drawings.Models
{
    public class DrawingSet
    {

        /// <summary>
        /// Drawing Set ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }
    }
}
