using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Meetings.Models {
	public class MeetingCategory {

		/// <summary>
		/// Meeting category id
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Meeting category topic
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Meeting category position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		/// <summary>
		/// Meeting category meeting topics
		/// </summary>
		[JsonProperty("meeting_topic")]	public  List<MeetingTopic> MeetingTopic { get ; set; }
	}
}
