using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Observations.Models
{
    public class ObservationItemAssigneesCompany
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
