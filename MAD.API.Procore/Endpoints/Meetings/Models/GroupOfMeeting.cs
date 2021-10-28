using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Meetings.Models {
	public class GroupOfMeeting {

		/// <summary>
		/// Meeting group title
		/// </summary>
		[JsonProperty("group_title")]	public  string GroupTitle { get ; set; }

		/// <summary>
		/// Meetings
		/// </summary>
		[JsonProperty("meetings")]	public  List<Meeting> Meetings { get ; set; }
	}
}
