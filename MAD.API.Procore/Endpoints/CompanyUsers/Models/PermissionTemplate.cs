using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CompanyUsers.Models {
	public class PermissionTemplate {

		/// <summary>
		/// Unique identifier for the Permission Template
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The name of the Permission Template
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// If the Permission Template is project specific
		/// </summary>
		[JsonProperty("project_specific")]	public  bool ProjectSpecific { get ; set; }

		/// <summary>
		/// The type of the Permission Template
		/// </summary>
		[JsonProperty("type")]	public  string Type { get ; set; }
	}
}
