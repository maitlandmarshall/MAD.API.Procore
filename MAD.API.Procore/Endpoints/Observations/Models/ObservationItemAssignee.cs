using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Observations.Models {
	public class ObservationItemAssignee {

		/// <summary>
		/// User ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// User's name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Company of User assigned to the Observation Item
		/// </summary>
		[JsonProperty("vendor")]	public  Vendor Vendor { get ; set; }
	}
}
