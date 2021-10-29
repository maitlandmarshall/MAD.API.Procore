using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.PunchItems.Models {
	public class Assignment {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Resolution status
		/// </summary>
		[JsonProperty("approved")]	public  bool Approved { get ; set; }

		/// <summary>
		/// Additional comments
		/// </summary>
		[JsonProperty("comment")]	public  string Comment { get ; set; }

		/// <summary>
		/// Date Assignee was notified
		/// </summary>
		[JsonProperty("notified_at")]	public  string NotifiedAt { get ; set; }

		/// <summary>
		/// Date Assignee response was updated on the Punch Item
		/// </summary>
		[JsonProperty("updated_at")]	public  string UpdatedAt { get ; set; }

		[JsonProperty("login_information")]	public  LoginInformation LoginInformation { get ; set; }

		/// <summary>
		/// Array of Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<Attachment> Attachments { get ; set; }
	}
}
