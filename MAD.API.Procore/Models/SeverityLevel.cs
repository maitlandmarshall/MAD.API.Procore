using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class SeverityLevel {

		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Name of the Incident Severity Level
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Denotes whether an email should be sent
		/// </summary>
		[JsonProperty("email_trigger")]	public  bool EmailTrigger { get ; set; }

		/// <summary>
		/// Denotes whether a push notification should be sent
		/// </summary>
		[JsonProperty("push_notification_trigger")]	public  bool PushNotificationTrigger { get ; set; }

		/// <summary>
		/// Ranking order of the Incident Severity Level
		/// </summary>
		[JsonProperty("order")]	public  int? Order { get ; set; }

		/// <summary>
		/// iso8601 timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// iso8601 timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }
	}
}
