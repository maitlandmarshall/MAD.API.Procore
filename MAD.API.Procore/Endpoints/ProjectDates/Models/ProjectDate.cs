using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ProjectDates.Models {
	public class ProjectDate {

		/// <summary>
		/// Project Date ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Project Date Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Project Date Date
		/// </summary>
		[JsonProperty("date")]	public  string Date { get ; set; }
	}
}
