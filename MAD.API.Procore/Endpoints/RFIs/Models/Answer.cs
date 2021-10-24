using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.RFIs.Models
{
    public class Answer
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Official response, true if official
        /// </summary>
        [JsonProperty("official")] public bool Official { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        [JsonProperty("answer_date")] public DateTimeOffset? AnswerDate { get; set; }

        /// <summary>
        /// Plain text body
        /// </summary>
        [JsonProperty("plain_text_body")] public string PlainTextBody { get; set; }

        /// <summary>
        /// Rich text body
        /// </summary>
        [JsonProperty("rich_text_body")] public string RichTextBody { get; set; }

        /// <summary>
        /// Creator name
        /// </summary>
        [JsonProperty("created_by")] public string CreatedBy { get; set; }

        /// <summary>
        /// Creator ID
        /// </summary>
        [JsonProperty("created_by_id")] public long? CreatedById { get; set; }

        /// <summary>
        /// Attachments
        /// </summary>
        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }
    }
}
