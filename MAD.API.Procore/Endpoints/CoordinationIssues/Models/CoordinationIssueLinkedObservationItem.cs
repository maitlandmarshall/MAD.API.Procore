using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssues.Models {
	public class CoordinationIssueLinkedObservationItem {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Observation Item number
		/// </summary>
		[JsonProperty("number")]	public  string Number { get ; set; }

		/// <summary>
		/// Formatted Observation Item title
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Deep-link URL to Observation Item
		/// </summary>
		[JsonProperty("url")]	public  string Url { get ; set; }
	}
}
