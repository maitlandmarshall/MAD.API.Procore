using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssues.Models {
	public class LinkedDrawing {

		/// <summary>
		/// Drawing ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Formatted title of the drawing
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Procore Web App URL of the drawing
		/// </summary>
		[JsonProperty("url")]	public  string Url { get ; set; }
	}
}
