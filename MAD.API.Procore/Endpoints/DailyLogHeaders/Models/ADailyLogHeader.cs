using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.DailyLogHeaders.Models {
	public class ADailyLogHeader {

		/// <summary>
		/// The id of the daily log header
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Date that this daily log header represents Format: YYYY-MM-DD Example: 2016-05-19
		/// </summary>
		[JsonProperty("log_date")]	public  string LogDate { get ; set; }

		/// <summary>
		/// Estimated UTC datetime that this daily log header represents
		/// </summary>
		[JsonProperty("log_datetime")]	public  DateTimeOffset? LogDatetime { get ; set; }

		/// <summary>
		/// Is this log date marked as complete?
		/// </summary>
		[JsonProperty("completed")]	public  bool Completed { get ; set; }

		[JsonProperty("completed_by")]	public  ADailyLogHeaderCompletedBy CompletedBy { get ; set; }

		/// <summary>
		/// Daily log header marked complete at
		/// </summary>
		[JsonProperty("completed_at")]	public  DateTimeOffset? CompletedAt { get ; set; }

		/// <summary>
		/// Is this log date able to be completed?
		/// </summary>
		[JsonProperty("completable")]	public  bool Completable { get ; set; }

		/// <summary>
		/// Is this log date marked as distributed?
		/// </summary>
		[JsonProperty("distributed")]	public  bool Distributed { get ; set; }

		[JsonProperty("distributed_by")]	public  ADailyLogHeaderDistributedBy DistributedBy { get ; set; }

		/// <summary>
		/// Daily log header marked distributed at
		/// </summary>
		[JsonProperty("distributed_at")]	public  DateTimeOffset? DistributedAt { get ; set; }

		/// <summary>
		/// Is this log date able to be distributed?
		/// </summary>
		[JsonProperty("distributable")]	public  bool Distributable { get ; set; }
	}
}
