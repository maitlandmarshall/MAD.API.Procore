using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class ResponseOption
    {

        /// <summary>
        /// Response Option ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Response Option Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}
