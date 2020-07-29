using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Inspector {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("login")]
		public string Login { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("company")]
		public JToken Company { get; set; }
	}
}
