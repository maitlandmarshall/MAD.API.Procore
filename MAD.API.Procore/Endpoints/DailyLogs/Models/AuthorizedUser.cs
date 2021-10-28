using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.DailyLogs.Models
{
    public class AuthorizedUser
    {

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}
