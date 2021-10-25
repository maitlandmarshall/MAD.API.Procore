using Newtonsoft.Json;
using System.Collections.Generic;

namespace MAD.API.Procore.Endpoints.PunchItemAssignments.Models
{
    public class PunchAssignment
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Resolution status
        /// </summary>
        [JsonProperty("approved")] public bool Approved { get; set; }

        /// <summary>
        /// Status of Assignment
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// Assignment's name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [JsonProperty("comment")] public string Comment { get; set; }

        [JsonProperty("login_information_id")] public long? LoginInformationId { get; set; }

        [JsonProperty("login_information_name")] public string LoginInformationName { get; set; }

        [JsonProperty("login_information")] public LoginInformation LoginInformation { get; set; }

        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }

        [JsonProperty("vendor")] public Vendor Vendor { get; set; }

        /// <summary>
        /// Date assignee was notified of Punch Item
        /// </summary>
        [JsonProperty("notified_at")] public string NotifiedAt { get; set; }

        /// <summary>
        /// Date Assignee responded to the Punch Item
        /// </summary>
        [JsonProperty("responded_at")] public string RespondedAt { get; set; }

        /// <summary>
        /// Date Punch Item Manager resolved the Punch Item Assignment
        /// </summary>
        [JsonProperty("manager_accepted_at")] public string ManagerAcceptedAt { get; set; }

        [JsonProperty("user_name")] public string UserName { get; set; }

        /// <summary>
        /// Date Assignment was updated
        /// </summary>
        [JsonProperty("updated_at")] public string UpdatedAt { get; set; }
    }
}
