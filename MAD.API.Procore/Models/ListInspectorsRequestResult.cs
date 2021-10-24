using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class ListInspectorsRequestResult
    {

        [JsonProperty("people")] public Inspector[] People { get; set; }
    }
}
