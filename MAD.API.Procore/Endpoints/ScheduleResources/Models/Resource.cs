using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ScheduleResources.Models {
	public class Resource {

		/// <summary>
		/// The unique identifier for this resource from the external system which owns the schedule data.
		/// </summary>
		[JsonProperty("source_uid")]	public  string SourceUid { get ; set; }

		/// <summary>
		/// Resource id
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Resource name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
