using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Meetings.Models {
	public class GroupOfMeetingMeeting {

		/// <summary>
		/// Meeting id
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Meeting title
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Meeting position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		/// <summary>
		/// Meeting description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Meeting mode
		/// </summary>
		[JsonProperty("mode")]	public  string Mode { get ; set; }

		/// <summary>
		/// Meeting date
		/// </summary>
		[JsonProperty("meeting_date")]	public  string MeetingDate { get ; set; }

		/// <summary>
		/// Meeting parent id
		/// </summary>
		[JsonProperty("parent_id")]	public  long? ParentId { get ; set; }
	}
}
