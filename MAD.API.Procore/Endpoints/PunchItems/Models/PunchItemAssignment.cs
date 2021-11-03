using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.PunchItems.Models {
	public class PunchItemAssignment {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Resolution status
		/// </summary>
		[JsonProperty("approved")]	public  bool Approved { get ; set; }

		/// <summary>
		/// Additional comment
		/// </summary>
		[JsonProperty("comment")]	public  string Comment { get ; set; }

		[JsonProperty("login_information_id")]	public  long? LoginInformationId { get ; set; }

		[JsonProperty("login_information_name")]	public  string LoginInformationName { get ; set; }

		[JsonProperty("login_information")]	public  PunchItemAssignmentLoginInformation LoginInformation { get ; set; }

		/// <summary>
		/// Array of Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<PunchItemAssignmentAttachment> Attachments { get ; set; }

		[JsonProperty("vendor")]	public  PunchItemAssignmentVendor Vendor { get ; set; }

		/// <summary>
		/// Date assignee was notified of Punch Item
		/// </summary>
		[JsonProperty("notified_at")]	public  DateTimeOffset? NotifiedAt { get ; set; }

		/// <summary>
		/// Date Assignee responded to the Punch Item
		/// </summary>
		[JsonProperty("responded_at")]	public  DateTimeOffset? RespondedAt { get ; set; }

		/// <summary>
		/// Date Punch Item Manager resolved the Punch Item Assignment
		/// </summary>
		[JsonProperty("manager_accepted_at")]	public  DateTimeOffset? ManagerAcceptedAt { get ; set; }

		[JsonProperty("user_name")]	public  string UserName { get ; set; }

		/// <summary>
		/// Date Assignment was updated
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }
	}
}
