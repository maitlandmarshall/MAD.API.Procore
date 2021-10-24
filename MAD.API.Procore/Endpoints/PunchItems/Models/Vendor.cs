using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.PunchItems.Models
{
    public class Vendor
    {

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}
