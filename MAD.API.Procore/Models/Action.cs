using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models
{
    public class Action
    {

        /// <summary>
        /// Action ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Incident ID
        /// </summary>
        [JsonProperty("incident_id")] public int? IncidentId { get; set; }

        [JsonProperty("action_type")] public ActionType ActionType { get; set; }

        [JsonProperty("attachments")] public List<IncidentAttachment> Attachments { get; set; }

        /// <summary>
        /// The account of the action in rich text form.
        /// </summary>
        [JsonProperty("description")] public string Description { get; set; }

        /// <summary>
        /// The account of the action plain text form.
        /// </summary>
        [JsonProperty("description_plain_text")] public string DescriptionPlainText { get; set; }

        /// <summary>
        /// Timestamp of creation
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of deletion
        /// </summary>
        [JsonProperty("deleted_at")] public DateTimeOffset? DeletedAt { get; set; }

        /// <summary>
        /// Timestamp of last update
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Observation ID
        /// </summary>
        [JsonProperty("observation_id")] public int? ObservationId { get; set; }
    }
}
