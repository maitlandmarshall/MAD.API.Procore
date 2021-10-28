using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences.Models {
	public class CreatedBy {

		/// <summary>
		/// The unique identifier of the user.
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The email address of the user that is used to log in.
		/// </summary>
		[JsonProperty("login")]	public  string Login { get ; set; }

		/// <summary>
		/// The name of the user.
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		[JsonProperty("company")]	public  Company Company { get ; set; }
	}
}
