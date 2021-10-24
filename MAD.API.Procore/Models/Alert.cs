using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Models
{
    public class Alert
    {

        /// <summary>
        /// Incident Alert ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Timestamp of email delivery
        /// </summary>
        [JsonProperty("emailed_at")] public DateTimeOffset? EmailedAt { get; set; }

        [JsonProperty("filing_type")] public IncidentFilingType FilingType { get; set; }

        [JsonProperty("injury")] public IncidentRecordBaseCompact Injury { get; set; }

        /// <summary>
        /// Timestamp of when the push notification delivery
        /// </summary>
        [JsonProperty("pushed_at")] public DateTimeOffset? PushedAt { get; set; }

        [JsonProperty("recipient")] public Recipient Recipient { get; set; }

        [JsonProperty("severity_level")] public SeverityLevel SeverityLevel { get; set; }

        /// <summary>
        /// Timestamp of when the alert was triggered
        /// </summary>
        [JsonProperty("triggered_at")] public DateTimeOffset? TriggeredAt { get; set; }

        [JsonProperty("triggered_by")] public TriggeredBy TriggeredBy { get; set; }
    }
}
