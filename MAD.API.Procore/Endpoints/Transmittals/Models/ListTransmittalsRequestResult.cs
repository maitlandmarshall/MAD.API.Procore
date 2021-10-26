using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Transmittals.Models
{
    public class ListTransmittalsRequestResult
    {

        [JsonProperty("cc_recipients")] public List<CcRecipient> CcRecipients { get; set; }

        /// <summary>
        /// Date created
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Sent Date
        /// </summary>
        [JsonProperty("sent_date")] public string SentDate { get; set; }

        /// <summary>
        /// Email sent date
        /// </summary>
        [JsonProperty("email_sent_date")] public string EmailSentDate { get; set; }

        /// <summary>
        /// Due date
        /// </summary>
        [JsonProperty("due_date")] public string DueDate { get; set; }

        /// <summary>
        /// Whether transmittal is private
        /// </summary>
        [JsonProperty("private")] public bool Private { get; set; }

        /// <summary>
        /// If sent_method is 'Under Separate Cover', describes the separate cover method
        /// </summary>
        [JsonProperty("sent_via")] public string SentVia { get; set; }

        [JsonProperty("to_recipients")] public List<ToRecipient> ToRecipients { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [JsonProperty("number")] public string Number { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        [JsonProperty("subject")] public string Subject { get; set; }
    }
}
