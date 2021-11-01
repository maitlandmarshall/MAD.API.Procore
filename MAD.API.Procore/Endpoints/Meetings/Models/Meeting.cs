using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Meetings.Models {
	public class Meeting {

		/// <summary>
		/// Meeting id
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Meeting position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		/// <summary>
		/// Meeting title
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Meeting location
		/// </summary>
		[JsonProperty("location")]	public  string Location { get ; set; }

		/// <summary>
		/// Meeting date
		/// </summary>
		[JsonProperty("meeting_date")]	public  string MeetingDate { get ; set; }

		/// <summary>
		/// Meeting occurred status
		/// </summary>
		[JsonProperty("occurred")]	public  bool Occurred { get ; set; }

		/// <summary>
		/// Meeting start time
		/// </summary>
		[JsonProperty("start_time")]	public  string StartTime { get ; set; }

		/// <summary>
		/// Meeting finish time
		/// </summary>
		[JsonProperty("finish_time")]	public  string FinishTime { get ; set; }

		/// <summary>
		/// Meeting Timezone
		/// </summary>
		[JsonProperty("time_zone")]	public  string TimeZone { get ; set; }

		/// <summary>
		/// Meeting private status
		/// </summary>
		[JsonProperty("is_private")]	public  bool IsPrivate { get ; set; }

		/// <summary>
		/// Meeting draft status
		/// </summary>
		[JsonProperty("is_draft")]	public  bool IsDraft { get ; set; }

		/// <summary>
		/// Meeting mode
		/// </summary>
		[JsonProperty("mode")]	public  string Mode { get ; set; }

		/// <summary>
		/// Meeting description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Meeting conclusion
		/// </summary>
		[JsonProperty("conclusion")]	public  string Conclusion { get ; set; }

		/// <summary>
		/// Meeting attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<MeetingAttachment> Attachments { get ; set; }

		/// <summary>
		/// Meeting attendees
		/// </summary>
		[JsonProperty("attendees")]	public  List<MeetingAttendee> Attendees { get ; set; }

		/// <summary>
		/// Meeting categories
		/// </summary>
		[JsonProperty("meeting_categories")]	public  List<MeetingMeetingCategory> MeetingCategories { get ; set; }
	}
}
