using Newtonsoft.Json;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ProjectDates.Models
{
    public class ProjectDatesMaster
    {
        [JsonProperty("schedule_dates")] public ScheduleDate ScheduleDates { get; set; }

        /// <summary>
        /// Array of Project Dates
        /// </summary>
        [JsonProperty("project_dates")] public List<ProjectDate> ChildProjectDates { get; set; }
    }
}