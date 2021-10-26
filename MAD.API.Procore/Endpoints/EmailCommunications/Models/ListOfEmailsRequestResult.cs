using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.EmailCommunications.Models
{
    public class ListOfEmailsRequestResult
    {

        /// <summary>
        /// An array of IDs of the Distributions of the topic
        /// </summary>
        [JsonProperty("emails")] public List<Email> Emails { get; set; }

        /// <summary>
        /// Total count of emails
        /// </summary>
        [JsonProperty("total")] public int? Total { get; set; }

        /// <summary>
        /// Email for creating a new communication thread associated with this topic
        /// </summary>
        [JsonProperty("new_communication_email")] public string NewCommunicationEmail { get; set; }
    }
}
