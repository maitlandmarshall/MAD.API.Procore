using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.CompanyVendors.Models
{
    public class Parent
    {

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}
