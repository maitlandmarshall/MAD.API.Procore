using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.EmailCommunications.Models {
	public class Email {

		/// <summary>
		/// Email ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Communication ID
		/// </summary>
		[JsonProperty("communication_id")]	public  long? CommunicationId { get ; set; }

		/// <summary>
		/// Subject of the email
		/// </summary>
		[JsonProperty("subject")]	public  string Subject { get ; set; }

		/// <summary>
		/// Private Indicator
		/// </summary>
		[JsonProperty("private")]	public  bool Private { get ; set; }

		/// <summary>
		/// Email attachnents
		/// </summary>
		[JsonProperty("attachments")]	public  List<Attachment> Attachments { get ; set; }

		/// <summary>
		/// Users on the email BCC distribution
		/// </summary>
		[JsonProperty("bcc_distribution")]	public  List<BccDistribution> BccDistribution { get ; set; }

		/// <summary>
		/// Company name
		/// </summary>
		[JsonProperty("body")]	public  string Body { get ; set; }

		/// <summary>
		/// Users on the email CC distribution
		/// </summary>
		[JsonProperty("cc_distribution")]	public  List<CcDistribution> CcDistribution { get ; set; }

		/// <summary>
		/// An array of users of the Distributions of the topic
		/// </summary>
		[JsonProperty("distribution")]	public  List<Distribution> Distribution { get ; set; }

		/// <summary>
		/// Date email sent
		/// </summary>
		[JsonProperty("email_sent_at")]	public  DateTimeOffset? EmailSentAt { get ; set; }

		/// <summary>
		/// User
		/// </summary>
		[JsonProperty("login_information")]	public  LoginInformation LoginInformation { get ; set; }
	}
}
