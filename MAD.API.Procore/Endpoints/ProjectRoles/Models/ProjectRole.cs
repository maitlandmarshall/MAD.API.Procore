using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ProjectRoles.Models {
	public class ProjectRole {

		/// <summary>
		/// Project role member id
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Project role member contact name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Project role name
		/// </summary>
		[JsonProperty("role")]	public  string Role { get ; set; }

		/// <summary>
		/// User id
		/// </summary>
		[JsonProperty("user_id")]	public  long? UserId { get ; set; }
	}
}
