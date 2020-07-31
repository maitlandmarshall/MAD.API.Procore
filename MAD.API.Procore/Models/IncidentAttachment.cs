using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class IncidentAttachment {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// URL
		/// </summary>
		[JsonProperty("url")]	public  string Url { get ; set; }

		/// <summary>
		/// URL
		/// </summary>
		[JsonProperty("thumbnail_url")]	public  string ThumbnailUrl { get ; set; }

		/// <summary>
		/// Filename
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		[JsonProperty("content_type")]	public  string ContentType { get ; set; }
	}
}
