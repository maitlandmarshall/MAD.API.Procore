using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistTemplateItem {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("section_id")]
		public int SectionId { get; set; }
		[JsonProperty("position")]
		public int Position { get; set; }
		[JsonProperty("response_set")]
		public JToken ResponseSet { get; set; }
	}
}
