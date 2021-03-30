using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistTemplateSection {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		[JsonProperty("items")]	public  List<ChecklistTemplateItem> Items { get ; set; }
	}
}
