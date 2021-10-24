using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class PermissionTemplate
    {

        /// <summary>
        /// The ID of the Permission Template
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// The name of the Permission Template
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// If the Permission Template is project specific
        /// </summary>
        [JsonProperty("project_specific")] public bool ProjectSpecific { get; set; }
    }
}
