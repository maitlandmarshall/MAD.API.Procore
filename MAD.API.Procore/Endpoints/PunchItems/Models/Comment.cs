using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.PunchItems.Models {
	public class Comment {

		/// <summary>
		/// Comment ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The text of the Comment
		/// </summary>
		[JsonProperty("body")]	public  string Body { get ; set; }

		[JsonProperty("creator")]	public  Creator Creator { get ; set; }

		/// <summary>
		/// Image Category created at
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Comment update timestamp
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }
	}
}
