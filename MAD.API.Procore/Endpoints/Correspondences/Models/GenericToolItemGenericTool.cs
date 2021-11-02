using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences.Models {
	public class GenericToolItemGenericTool {

		/// <summary>
		/// Unique identifier for the generic tool.
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Primary name/title for the generic tool.
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }
	}
}
