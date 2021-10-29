using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.DailyLogs.Models {
	public class GetTotalWorkersAndManHoursRequestResult {

		/// <summary>
		/// Total sum of workers for the specified logs
		/// </summary>
		[JsonProperty("total_workers")]	public  int? TotalWorkers { get ; set; }

		/// <summary>
		/// Total sum of man hours for the specified logs
		/// </summary>
		[JsonProperty("total_man_hours")]	public  decimal? TotalManHours { get ; set; }
	}
}
