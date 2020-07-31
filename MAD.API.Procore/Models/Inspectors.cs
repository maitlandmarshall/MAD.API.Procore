using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Inspectors {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// Email
		/// </summary>
		[JsonProperty("login")]		public string Login { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }
	}
}
