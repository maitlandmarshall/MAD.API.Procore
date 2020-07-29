using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistDefaultResponseSet {
		[JsonProperty("conforming_response")]
		public string ConformingResponse { get; set; }
		[JsonProperty("deficient_response")]
		public string DeficientResponse { get; set; }
		[JsonProperty("global")]
		public bool Global { get; set; }
	}
}
