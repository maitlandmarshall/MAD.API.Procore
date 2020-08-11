using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ResponseSet {

		/// <summary>
		/// ID of the response set
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Name of the response set
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		[JsonProperty("responses")]	public  List<ChecklistResponse> Responses { get ; set; }
	}
}
