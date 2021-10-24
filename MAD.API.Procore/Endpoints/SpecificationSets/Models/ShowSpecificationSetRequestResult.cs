using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.SpecificationSets.Models
{
    public class ShowSpecificationSetRequestResult
    {

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("date")] public string Date { get; set; }

        [JsonProperty("position")] public int? Position { get; set; }
    }
}
