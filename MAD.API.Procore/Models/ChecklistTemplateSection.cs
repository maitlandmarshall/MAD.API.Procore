using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistTemplateSection {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("position")]
		public int Position { get; set; }
		[JsonProperty("items")]
		public ChecklistTemplateItem[] Items { get; set; }
	}
}
