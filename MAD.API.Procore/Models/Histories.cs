using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class History {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Text describing the status change
		/// </summary>
		[JsonProperty("body")]	public  string Body { get ; set; }

		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Name of Response at time of inspection
		/// </summary>
		[JsonProperty("responded_with")]	public  string RespondedWith { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		[JsonProperty("created_by")]	public  CreatedBy CreatedBy { get ; set; }
	}
}
