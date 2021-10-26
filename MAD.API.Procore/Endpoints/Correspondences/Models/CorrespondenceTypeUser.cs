using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences.Models
{
    public class CorrespondenceTypeUser
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("company")] public Company Company { get; set; }

        [JsonProperty("generic_tools")] public List<GenericTool> GenericTools { get; set; }
    }
}
