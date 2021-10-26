using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Instructions.Models
{
    public class Group
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("user_ids")] public List<long> UserIds { get; set; }
    }
}
