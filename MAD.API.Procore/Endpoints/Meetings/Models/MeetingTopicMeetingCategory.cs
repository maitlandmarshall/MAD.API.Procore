using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Meetings.Models {
	public class MeetingTopicMeetingCategory {

		/// <summary>
		/// Meeting category id
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Meeting category title
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }
	}
}
