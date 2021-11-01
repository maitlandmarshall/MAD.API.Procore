using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ManpowerLogs.Models {
	public class ListManpowerLogsRequestResultVendor {

		/// <summary>
		/// Vendor ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Vendor Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
