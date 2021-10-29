using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Drawings.Models {
	public class Discipline {

		/// <summary>
		/// Discipline ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Discipline name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Discipline position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }
	}
}
