using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ResponseOption {

		/// <summary>
		/// Response Option ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// Response Option Name
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }
	}
}
