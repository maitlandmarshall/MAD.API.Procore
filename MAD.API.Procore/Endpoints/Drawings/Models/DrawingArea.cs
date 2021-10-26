using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Drawings.Models
{
    public class DrawingArea
    {

        /// <summary>
        /// Drawing Area ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }
    }
}
