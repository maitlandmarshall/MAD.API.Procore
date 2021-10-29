using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Observations.Models {
	public class CreatedBy {

		/// <summary>
		/// User ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// User name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
