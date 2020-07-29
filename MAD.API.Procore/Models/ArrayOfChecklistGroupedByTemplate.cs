using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ArrayOfChecklistGroupedByTemplate {
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("template_id")]
		public int TemplateId { get; set; }
		[JsonProperty("response_set")]
		public ChecklistDefaultResponseSet ResponseSet { get; set; }
		[JsonProperty("lists")]
		public Checklist[] Lists { get; set; }
	}
}
