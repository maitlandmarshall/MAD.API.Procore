using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Projects.Models {
	public class ProjectDepartment {

		/// <summary>
		/// The identifier for the Project Department
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The name for the Project Department
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
