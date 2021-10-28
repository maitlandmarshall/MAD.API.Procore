using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class ResponsibleContractor
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }
    }
}