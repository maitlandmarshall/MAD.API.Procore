using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.EmailCommunications.Models
{
    public class ShowEmailCommunicationRequestResult
    {

        /// <summary>
        /// Communication ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Private Indicator
        /// </summary>
        [JsonProperty("private")] public bool Private { get; set; }

        /// <summary>
        /// Subject of the email communication
        /// </summary>
        [JsonProperty("subject")] public string Subject { get; set; }

        /// <summary>
        /// Emails
        /// </summary>
        [JsonProperty("emails")] public List<Email> Emails { get; set; }
    }
}
