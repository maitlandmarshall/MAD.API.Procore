using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class User {

		/// <summary>
		/// User ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// User Login
		/// </summary>
		[JsonProperty("login")]	public  string Login { get ; set; }

		/// <summary>
		/// User Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
