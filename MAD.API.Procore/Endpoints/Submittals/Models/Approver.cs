using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Submittals.Models
{
    public class Approver
    {

        /// <summary>
        /// Role of Approver
        /// </summary>
        [JsonProperty("approver_type")] public string ApproverType { get; set; }

        [JsonProperty("comment")] public string Comment { get; set; }

        [JsonProperty("distributed")] public bool Distributed { get; set; }

        [JsonProperty("response")] public Response Response { get; set; }

        /// <summary>
        /// Returned Date
        /// </summary>
        [JsonProperty("returned_date")] public string ReturnedDate { get; set; }

        /// <summary>
        /// Sent Date
        /// </summary>
        [JsonProperty("sent_date")] public string SentDate { get; set; }

        /// <summary>
        /// Due Date
        /// </summary>
        [JsonProperty("due_date")] public string DueDate { get; set; }

        [JsonProperty("user")] public User User { get; set; }

        /// <summary>
        /// Attachments
        /// </summary>
        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Submittal Associated Attachment IDs
        /// </summary>
        [JsonProperty("submittal_associated_attachment_ids")] public List<long> SubmittalAssociatedAttachmentIds { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }
    }
}
