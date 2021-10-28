using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences.Models {
	public class UserAccessLevel {

		/// <summary>
		/// access level
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// friendly name for level
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// actions supported by access level by tool
		/// </summary>
		[JsonProperty("permitted_actions")]	public  PermittedAction PermittedActions { get ; set; }
	}
}
