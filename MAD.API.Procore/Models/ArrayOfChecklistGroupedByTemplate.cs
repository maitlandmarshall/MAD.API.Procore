using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ArrayOfChecklistGroupedByTemplate {

		/// <summary>
		/// Checklist template name
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }

		/// <summary>
		/// Checklist template ID
		/// </summary>
		[JsonProperty("template_id")]		public int? TemplateId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("response_set")]		public ChecklistDefaultResponseSet ResponseSet { get; set; }

		/// <summary>
		/// Array of Checklists
		/// </summary>
		[JsonProperty("lists")]		public Checklist[] Lists { get; set; }
	}
}
