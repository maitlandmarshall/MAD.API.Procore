using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Submittals.Models {
	public class DistributedBy {

		/// <summary>
		/// Email
		/// </summary>
		[JsonProperty("login")]	public  string Login { get ; set; }

		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
