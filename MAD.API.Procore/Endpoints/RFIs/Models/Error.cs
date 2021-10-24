using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.RFIs.Models
{
    public class Error
    {

        [JsonProperty("errors")] public string Errors { get; set; }
    }
}
