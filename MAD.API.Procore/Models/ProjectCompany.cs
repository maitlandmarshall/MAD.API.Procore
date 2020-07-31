using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ProjectCompany {

		/// <summary>
		/// Company ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Company name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
