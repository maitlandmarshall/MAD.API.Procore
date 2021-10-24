using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace MAD.API.Procore.Endpoints.InspectionUsers.Models
{
    public class InspectionUser
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
        /// Represents whether or not a user can be an Inspector for an Inspection.
        /// </summary>
        [JsonProperty("potential_inspector")] public bool PotentialInspector { get; set; }

        /// <summary>
        /// Represents whether or not a user can be a Point of Contact for an Inspection.
        /// </summary>
        [JsonProperty("potential_point_of_contact")] public bool PotentialPointOfContact { get; set; }

        /// <summary>
        /// Represents whether or not a user can be a Distribution Member for an Inspection.
        /// </summary>
        [JsonProperty("potential_distribution_member")] public bool PotentialDistributionMember { get; set; }

        /// <summary>
        /// Represents whether or not a user is a Default Distribution Member for Inspections.
        /// </summary>
        [JsonProperty("default_distribution_member")] public bool DefaultDistributionMember { get; set; }

        [JsonProperty("custom_fields")] public JObject CustomFields { get; set; }
    }
}
