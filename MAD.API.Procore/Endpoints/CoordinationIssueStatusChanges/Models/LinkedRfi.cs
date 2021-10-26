using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.CoordinationIssueStatusChanges.Models
{
    public class LinkedRfi
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Id of the associated Coordination Issue
        /// </summary>
        [JsonProperty("coordination_issue_id")] public long? CoordinationIssueId { get; set; }

        /// <summary>
        /// Id of the associated Procore item
        /// </summary>
        [JsonProperty("item_id")] public long? ItemId { get; set; }

        /// <summary>
        /// Type of the associated Procore item
        /// </summary>
        [JsonProperty("item_type")] public string ItemType { get; set; }

        /// <summary>
        /// Deep-link URL to the associated Procore item
        /// </summary>
        [JsonProperty("item_url")] public string ItemUrl { get; set; }

        /// <summary>
        /// This field shows data specific to the associated item. If item type is RFI, it will contain attribute subject, number, and has_official_response
        /// </summary>
        [JsonProperty("item_data")] public ItemDatum ItemData { get; set; }
    }
}
