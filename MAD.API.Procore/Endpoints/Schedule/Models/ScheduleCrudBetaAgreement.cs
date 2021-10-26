using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Schedule.Models
{
    public class ScheduleCrudBetaAgreement
    {

        [JsonProperty("signed")] public bool Signed { get; set; }

        [JsonProperty("version")] public string Version { get; set; }
    }
}
