using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Projects.Models {
	public class ProjectType {

		/// <summary>
		/// The identifier for the Project Type
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The name for the Project Type
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
