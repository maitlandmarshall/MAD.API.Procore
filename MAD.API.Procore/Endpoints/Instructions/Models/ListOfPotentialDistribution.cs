using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Instructions.Models
{
    public class ListOfPotentialDistribution
    {

        /// <summary>
        /// Array of Potential Contacts
        /// </summary>
        [JsonProperty("people")] public List<PotentialDistribution> People { get; set; }

        /// <summary>
        /// Array of Distribution Groups
        /// </summary>
        [JsonProperty("groups")] public List<DistributionGroup> Groups { get; set; }
    }
}
