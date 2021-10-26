using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.FormsUsers.Models
{
    public class FormsUser
    {

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// User's Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("vendor")] public Vendor Vendor { get; set; }

        /// <summary>
        /// Represents whether or not a user can be a Distribution Member for a Form.
        /// </summary>
        [JsonProperty("potential_distribution_member")] public bool PotentialDistributionMember { get; set; }
    }
}
