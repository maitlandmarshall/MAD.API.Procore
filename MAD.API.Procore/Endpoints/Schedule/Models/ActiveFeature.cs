using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Schedule.Models {
	public class ActiveFeature {

		[JsonProperty("schedule_activity_feed")]	public  bool ScheduleActivityFeed { get ; set; }

		[JsonProperty("schedule_comment_mentions")]	public  bool ScheduleCommentMentions { get ; set; }

		[JsonProperty("schedule_gantt_crud")]	public  bool ScheduleGanttCrud { get ; set; }

		[JsonProperty("schedule_task_comments")]	public  bool ScheduleTaskComments { get ; set; }

		[JsonProperty("schedule_task_details")]	public  bool ScheduleTaskDetails { get ; set; }

		[JsonProperty("schedule_linked_items")]	public  bool ScheduleLinkedItems { get ; set; }

		[JsonProperty("lookaheads_activity_feed")]	public  bool LookaheadsActivityFeed { get ; set; }
	}
}
