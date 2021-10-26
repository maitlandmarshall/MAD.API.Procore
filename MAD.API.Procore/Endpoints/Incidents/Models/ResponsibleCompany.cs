using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Incidents.Models
{
    public class ResponsibleCompany
    {

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}
