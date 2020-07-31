using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class CreatedBy {

		/// <summary>
		/// Email
		/// </summary>
		[JsonProperty("login")]		public string Login { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }
	}
}
