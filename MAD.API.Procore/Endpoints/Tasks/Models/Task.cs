using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Tasks.Models {
	public class Task {

		/// <summary>
		/// Unique identifier for this task.
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Task name as the user sees it in Procore. Depending on the project settings this may include the full outline path
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Task name. This will always contain just the task name, and will not include the full outline path.
		/// </summary>
		[JsonProperty("task_name")]	public  string TaskName { get ; set; }

		/// <summary>
		/// A deprecated value which was originally used to uniquely identify tasks.
		/// This value will be removed in a later version of the API.
		/// </summary>
		[JsonProperty("key")]	public  string Key { get ; set; }

		/// <summary>
		/// Task start timestamp.
		/// </summary>
		[JsonProperty("start_datetime")]	public  DateTimeOffset? StartDatetime { get ; set; }

		/// <summary>
		/// Task finish timestamp.
		/// </summary>
		[JsonProperty("finish_datetime")]	public  DateTimeOffset? FinishDatetime { get ; set; }

		/// <summary>
		/// Percent complete value for this task.
		/// </summary>
		[JsonProperty("percentage")]	public  int? Percentage { get ; set; }

		/// <summary>
		/// The RGB color value, expressed in hex digits for the color used when
		/// displaying the task in Procore. The color varies depending on whether
		/// the task is on the critical path, complete, unstarted or in progress.
		/// </summary>
		[JsonProperty("color")]	public  string Color { get ; set; }

		/// <summary>
		/// ID of the parent task.
		/// </summary>
		[JsonProperty("parent_id")]	public  long? ParentId { get ; set; }

		/// <summary>
		/// True if one or more change requests are pending for this task.
		/// </summary>
		[JsonProperty("pending")]	public  bool? Pending { get ; set; }

		/// <summary>
		/// The external unique identifier for this task. Note that due to an
		/// oversight in the original API, the value returned for this attribute
		/// will be the `source_uid` value supplied when creating a task.
		/// </summary>
		[JsonProperty("activity_id")]	public  string ActivityId { get ; set; }

		/// <summary>
		/// For tasks imported from external systems which have the concept of
		/// an "Activity ID" (for example Primavera P6), this attribute is
		/// used to hold the Activity ID value. Note that due to an oversight
		/// during the creation of this API, this is the value supplied
		/// in the `activity_id` attribute. This will be corrected in a later
		/// version of the API.
		/// </summary>
		[JsonProperty("schedule_activity_id")]	public  string ScheduleActivityId { get ; set; }

		/// <summary>
		/// Names of any resources assigned to this task.
		/// </summary>
		[JsonProperty("resource_name")]	public  string ResourceName { get ; set; }

		/// <summary>
		/// True if this task is on the critical path.
		/// </summary>
		[JsonProperty("critical_path")]	public  bool? CriticalPath { get ; set; }

		/// <summary>
		/// True if this task is a milestone.
		/// </summary>
		[JsonProperty("milestone")]	public  bool? Milestone { get ; set; }

		/// <summary>
		/// Actual start timestamp for this task.
		/// </summary>
		[JsonProperty("actual_start")]	public  DateTimeOffset? ActualStart { get ; set; }

		/// <summary>
		/// Actual finish timestamp for this task.
		/// </summary>
		[JsonProperty("actual_finish")]	public  DateTimeOffset? ActualFinish { get ; set; }

		/// <summary>
		/// The row number of a task defines the sequence in which tasks are normally
		/// expected to be displayed.
		/// </summary>
		[JsonProperty("row_number")]	public  int? RowNumber { get ; set; }

		/// <summary>
		/// True if this is a summary task, i.e. this task has child tasks.
		/// </summary>
		[JsonProperty("has_children")]	public  bool? HasChildren { get ; set; }

		/// <summary>
		/// Task full outline path
		/// </summary>
		[JsonProperty("full_outline_path")]	public  string FullOutlinePath { get ; set; }

		/// <summary>
		/// The unique identifier for this task from the external system which
		/// owns the schedule data.
		/// </summary>
		[JsonProperty("source_uid")]	public  string SourceUid { get ; set; }

		/// <summary>
		/// Work Breakdown Structure (WBS) number for this task.
		/// </summary>
		[JsonProperty("wbs")]	public  string Wbs { get ; set; }

		/// <summary>
		/// The duration of this task in days as defined by the external system
		/// which owns the schedule data.
		/// </summary>
		[JsonProperty("schedule_duration")]	public  decimal? ScheduleDuration { get ; set; }

		/// <summary>
		/// The resources assigned to this task, represented as an array of
		/// resource ID values.
		/// </summary>
		[JsonProperty("resource_ids")]	public  List<long> ResourceIds { get ; set; }

		/// <summary>
		/// Arbitrary notes about this task.
		/// </summary>
		[JsonProperty("notes")]	public  string Notes { get ; set; }

		/// <summary>
		/// The baseline start timestamp for this task.
		/// </summary>
		[JsonProperty("baseline_start")]	public  DateTimeOffset? BaselineStart { get ; set; }

		/// <summary>
		/// The baseline finish timestamp for this task.
		/// </summary>
		[JsonProperty("baseline_finish")]	public  DateTimeOffset? BaselineFinish { get ; set; }

		/// <summary>
		/// The start variance in days for this task.
		/// </summary>
		[JsonProperty("start_variance")]	public  decimal? StartVariance { get ; set; }

		/// <summary>
		/// The finish variance in days for this task.
		/// </summary>
		[JsonProperty("finish_variance")]	public  decimal? FinishVariance { get ; set; }

		/// <summary>
		/// Set to true if the task has been created or modified in Procore, false
		/// if the task was imported from an external schedule and has not been
		/// modified in Procore.
		/// </summary>
		[JsonProperty("manually_edited")]	public  bool? ManuallyEdited { get ; set; }

		/// <summary>
		/// Date/time the Task was created.
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset? CreatedAt { get ; set; }

		/// <summary>
		/// Date/time the Task was last updated.
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset? UpdatedAt { get ; set; }

		[JsonProperty("created_by")]	public  TaskCreatedBy CreatedBy { get ; set; }

		[JsonProperty("updated_by")]	public  TaskUpdatedBy UpdatedBy { get ; set; }
	}
}
