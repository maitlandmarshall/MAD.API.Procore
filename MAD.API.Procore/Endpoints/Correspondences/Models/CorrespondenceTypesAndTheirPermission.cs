using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences.Models
{
    public class CorrespondenceTypesAndTheirPermission
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("friendly_name")] public string FriendlyName { get; set; }

        [JsonProperty("domain_id")] public long? DomainId { get; set; }

        [JsonProperty("tab_group")] public string TabGroup { get; set; }

        [JsonProperty("available_for_user")] public bool AvailableForUser { get; set; }

        [JsonProperty("url")] public string Url { get; set; }

        [JsonProperty("user_access_level")] public UserAccessLevel UserAccessLevel { get; set; }

        [JsonProperty("permitted_actions")] public List<PermittedAction> PermittedActions { get; set; }
    }
}
