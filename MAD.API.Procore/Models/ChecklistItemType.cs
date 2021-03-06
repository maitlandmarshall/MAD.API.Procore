using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistItemType {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

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
