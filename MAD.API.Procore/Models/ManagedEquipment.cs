using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class ManagedEquipment
    {

        /// <summary>
        /// Equipment ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Equipment name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
