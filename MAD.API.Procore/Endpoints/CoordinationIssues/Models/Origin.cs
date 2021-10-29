using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssues.Models {
	public class Origin {

		/// <summary>
		/// Title of the origin item
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Id of the origin item
		/// </summary>
		[JsonProperty("origin_id")]	public  string OriginId { get ; set; }

		/// <summary>
		/// Type of origin item
		/// </summary>
		[JsonProperty("origin_type")]	public  string OriginType { get ; set; }

		/// <summary>
		/// Deep link URL to the origin item
		/// </summary>
		[JsonProperty("deep_link_url")]	public  string DeepLinkUrl { get ; set; }
	}
}
