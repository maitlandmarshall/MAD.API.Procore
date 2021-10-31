using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ChecklistsGroupedByTemplate {

		/// <summary>
		/// Checklist template name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Checklist template ID
		/// </summary>
		[JsonProperty("template_id")]	public  long? TemplateId { get ; set; }

		[JsonProperty("response_set")]	public  ChecklistDefaultResponseSet ResponseSet { get ; set; }

		/// <summary>
		/// Array of Checklists
		/// </summary>
		[JsonProperty("lists")]	public  List<Checklist> Lists { get ; set; }
	}
}
