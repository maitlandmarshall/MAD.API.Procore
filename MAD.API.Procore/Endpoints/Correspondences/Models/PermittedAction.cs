using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Correspondences.Models
{
    public class PermittedAction
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("action_name")] public string ActionName { get; set; }

        [JsonProperty("label")] public string Label { get; set; }

        [JsonProperty("tool_name")] public string ToolName { get; set; }
    }
}
