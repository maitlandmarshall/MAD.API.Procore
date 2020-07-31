using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Items {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }

		/// <summary>
		/// Status
		/// </summary>
		[JsonProperty("status")]		public string Status { get; set; }

		/// <summary>
		/// Checklist Section ID
		/// </summary>
		[JsonProperty("section_id")]		public int? SectionId { get; set; }

		/// <summary>
		/// Position
		/// </summary>
		[JsonProperty("position")]		public int? Position { get; set; }
	}
}
