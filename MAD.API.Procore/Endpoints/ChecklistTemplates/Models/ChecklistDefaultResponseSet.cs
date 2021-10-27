using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ChecklistTemplates.Models {
	public class ChecklistDefaultResponseSet {

		/// <summary>
		/// Term used to represent conforming statuses on items within the current template, e.g. "Pass" or "Safe". This maps to an item status of "yes".
		/// </summary>
		[JsonProperty("conforming_response")]	public  string ConformingResponse { get ; set; }

		/// <summary>
		/// Term used to represent deficient statuses on items within the current template, e.g. "Fail" or "At Risk".  This maps to an item status of "no".
		/// </summary>
		[JsonProperty("deficient_response")]	public  string DeficientResponse { get ; set; }

		/// <summary>
		/// Represents whether a response set has been provided by Procore.
		/// </summary>
		[JsonProperty("global")]	public  bool Global { get ; set; }
	}
}
