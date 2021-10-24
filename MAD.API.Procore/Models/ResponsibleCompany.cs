using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class ResponsibleCompany
    {

        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}
