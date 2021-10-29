using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ProjectDates.Models {
	public class ListProjectDatesRequestResult {

		[JsonProperty("schedule_dates")]	public  ScheduleDate ScheduleDates { get ; set; }

		/// <summary>
		/// Array of Project Dates
		/// </summary>
		[JsonProperty("project_dates")]	public  List<ProjectDate> ProjectDates { get ; set; }
	}
}
