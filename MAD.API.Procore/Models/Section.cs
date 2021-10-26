using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Models
{
    public class Section
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        [JsonProperty("position")] public int? Position { get; set; }

        /// <summary>
        /// Checklist Items
        /// </summary>
        [JsonProperty("items")] public List<Item> Items { get; set; }
    }
}
