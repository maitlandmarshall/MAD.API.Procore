using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Submittals.Models {
	public class Response {

		/// <summary>
		/// Name of Submittal Response
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Mapping of the Submittal Response
		/// </summary>
		[JsonProperty("considered")]	public  string Considered { get ; set; }

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }
	}
}
