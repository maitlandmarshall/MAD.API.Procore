using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ChecklistItemType {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The category of the Item Type
		/// </summary>
		[JsonProperty("category")]	public  string Category { get ; set; }

		/// <summary>
		/// The name of the Item Type
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
