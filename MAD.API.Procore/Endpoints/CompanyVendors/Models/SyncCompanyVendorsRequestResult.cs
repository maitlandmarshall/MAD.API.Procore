using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CompanyVendors.Models
{
    public class SyncCompanyVendorsRequestResult
    {

        /// <summary>
        /// Array of updated entities
        /// </summary>
        [JsonProperty("entities")] public List<Entity> Entities { get; set; }

        [JsonProperty("errors")] public List<Error> Errors { get; set; }
    }
}
