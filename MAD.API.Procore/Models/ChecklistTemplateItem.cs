using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistTemplateItem {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Checklist Template Section ID
		/// </summary>
		[JsonProperty("section_id")]	public  long? SectionId { get ; set; }

		/// <summary>
		/// Position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		[JsonProperty("response_set")]	public  ResponseSet ResponseSet { get ; set; }
	}
}
