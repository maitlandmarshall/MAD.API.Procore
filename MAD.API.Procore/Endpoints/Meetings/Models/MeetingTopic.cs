using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Meetings.Models
{
    public class MeetingTopic
    {

        /// <summary>
        /// Meeting topic id
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Meeting topic number
        /// </summary>
        [JsonProperty("number")] public string Number { get; set; }

        /// <summary>
        /// Meeting topic created on
        /// </summary>
        [JsonProperty("created_on")] public string CreatedOn { get; set; }

        /// <summary>
        /// Meeting topic position
        /// </summary>
        [JsonProperty("position")] public int? Position { get; set; }

        /// <summary>
        /// Meeting topic due date
        /// </summary>
        [JsonProperty("due_date")] public string DueDate { get; set; }

        /// <summary>
        /// Meeting topic priority
        /// </summary>
        [JsonProperty("priority")] public string Priority { get; set; }

        /// <summary>
        /// Meeting topic status
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// Meeting topic title
        /// </summary>
        [JsonProperty("title")] public string Title { get; set; }

        /// <summary>
        /// Meeting topic minutes
        /// </summary>
        [JsonProperty("minutes")] public string Minutes { get; set; }

        /// <summary>
        /// Meeting topic description
        /// </summary>
        [JsonProperty("description")] public string Description { get; set; }

        /// <summary>
        /// Meeting category
        /// </summary>
        [JsonProperty("meeting_category")] public MeetingCategory MeetingCategory { get; set; }

        /// <summary>
        /// Meeting topic assignments
        /// </summary>
        [JsonProperty("assignments")] public List<Assignment> Assignments { get; set; }

        /// <summary>
        /// Meeting topic attachments
        /// </summary>
        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }
    }
}
