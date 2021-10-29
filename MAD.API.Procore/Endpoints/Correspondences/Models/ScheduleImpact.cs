using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences.Models {
	public class ScheduleImpact {

		/// <summary>
		/// Schedule impact status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Schedule impact value
		/// </summary>
		[JsonProperty("value")]	public  decimal? Value { get ; set; }
	}
}
