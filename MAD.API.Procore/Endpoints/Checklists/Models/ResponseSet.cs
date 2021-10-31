using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ResponseSet {

		/// <summary>
		/// ID of the response set
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Name of the response set
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		[JsonProperty("responses")]	public  List<ChecklistResponse> Responses { get ; set; }

		/// <summary>
		/// Timestamp of inspection creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }
	}
}
