using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ManpowerLogs.Models {
	public class ListManpowerLogsRequestResult {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Created at
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Date of record
		/// </summary>
		[JsonProperty("date")]	public  string Date { get ; set; }

		/// <summary>
		/// Estimated UTC datetime of record
		/// </summary>
		[JsonProperty("datetime")]	public  DateTimeOffset? Datetime { get ; set; }

		/// <summary>
		/// Deleted at
		/// </summary>
		[JsonProperty("deleted_at")]	public  DateTimeOffset? DeletedAt { get ; set; }

		/// <summary>
		/// Total man hours (num_workers x num_hours)
		/// </summary>
		[JsonProperty("man_hours")]	public  string ManHours { get ; set; }

		/// <summary>
		/// Additional notes
		/// </summary>
		[JsonProperty("notes")]	public  string Notes { get ; set; }

		/// <summary>
		/// Number of workers
		/// </summary>
		[JsonProperty("num_workers")]	public  int? NumWorkers { get ; set; }

		/// <summary>
		/// Number of hours for each worker
		/// </summary>
		[JsonProperty("num_hours")]	public  string NumHours { get ; set; }

		/// <summary>
		/// Position in which this entry was recorded for the day
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		/// <summary>
		/// Is a log pending or approved
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Updated at
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// This key is available when Contact is a Vendor
		/// </summary>
		[JsonProperty("vendor")]	public  ListManpowerLogsRequestResultVendor Vendor { get ; set; }

		/// <summary>
		/// This key is available when Contact is a User
		/// </summary>
		[JsonProperty("user")]	public  ListManpowerLogsRequestResultUser User { get ; set; }

		[JsonProperty("contact")]	public  ListManpowerLogsRequestResultContact Contact { get ; set; }

		[JsonProperty("cost_code")]	public  ListManpowerLogsRequestResultCostCode CostCode { get ; set; }

		[JsonProperty("created_by")]	public  ListManpowerLogsRequestResultCreatedBy CreatedBy { get ; set; }

		[JsonProperty("location")]	public  Location Location { get ; set; }

		/// <summary>
		/// :filename to be deprecated, use :name
		/// </summary>
		[JsonProperty("attachments")]	public  List<ListManpowerLogsRequestResultAttachment> Attachments { get ; set; }

		[JsonProperty("trade")]	public  Trade Trade { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }
	}
}
