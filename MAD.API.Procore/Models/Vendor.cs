using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class Vendor
    {

        /// <summary>
        /// Vendor ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Vendor Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
