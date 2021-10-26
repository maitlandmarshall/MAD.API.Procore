using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Instructions.Models
{
    public class Company
    {

        /// <summary>
        /// Vendor ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Vendor name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
