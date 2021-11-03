using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CalendarItems.Models {
	public class ScheduleCalendarItem {

		/// <summary>
		/// Calendar Item ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("assigned")]	public  ScheduleCalendarItemAssigned Assigned { get ; set; }

		/// <summary>
		/// Calendar Item color (as a hex triplet)
		/// </summary>
		[JsonProperty("color")]	public  string Color { get ; set; }

		[JsonProperty("created_by")]	public  ScheduleCalendarItemCreatedBy CreatedBy { get ; set; }

		/// <summary>
		/// Calendar Item description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Calendar Item finish date
		/// </summary>
		[JsonProperty("finish")]	public  string Finish { get ; set; }

		/// <summary>
		/// ToDo full outline path (corresponds to matching field on Tasks)
		/// </summary>
		[JsonProperty("full_outline_path")]	public  string FullOutlinePath { get ; set; }

		/// <summary>
		/// Calendar Item milestone status
		/// </summary>
		[JsonProperty("milestone")]	public  bool Milestone { get ; set; }

		/// <summary>
		/// Calendar Item name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Calendar Item completion percentage
		/// </summary>
		[JsonProperty("percentage")]	public  int? Percentage { get ; set; }

		/// <summary>
		/// Calendar Item private status
		/// </summary>
		[JsonProperty("private")]	public  bool Private { get ; set; }

		/// <summary>
		/// Calendar Item start date
		/// </summary>
		[JsonProperty("start")]	public  string Start { get ; set; }

		/// <summary>
		/// Calendar Item name (corresponds to matching field on Tasks)
		/// </summary>
		[JsonProperty("task_name")]	public  string TaskName { get ; set; }

		/// <summary>
		/// Calendar Item last updated at
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }
	}
}
