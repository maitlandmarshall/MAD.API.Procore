using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Company {

		/// <summary>
		/// Company ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// Company name
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }
	}
}
