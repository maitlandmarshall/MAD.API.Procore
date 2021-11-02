using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Schedule.Models {
	public class GetScheduleMetadataRequestResult {

		[JsonProperty("active_features")]	public  GetScheduleMetadataRequestResultActiveFeature ActiveFeatures { get ; set; }

		[JsonProperty("last_calendar_view")]	public  string LastCalendarView { get ; set; }

		[JsonProperty("schedule_present")]	public  bool SchedulePresent { get ; set; }

		[JsonProperty("schedule_processing")]	public  bool ScheduleProcessing { get ; set; }

		[JsonProperty("schedule_crud_beta_agreement")]	public  GetScheduleMetadataRequestResultScheduleCrudBetaAgreement ScheduleCrudBetaAgreement { get ; set; }

		/// <summary>
		/// Timestamp of the most recent change to any task in the Schedule.
		/// </summary>
		[JsonProperty("schedule_tasks_last_updated_at")]	public  DateTimeOffset? ScheduleTasksLastUpdatedAt { get ; set; }

		[JsonProperty("type")]	public  GetScheduleMetadataRequestResultType Type { get ; set; }
	}
}
