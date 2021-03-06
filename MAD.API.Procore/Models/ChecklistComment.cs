using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistComment {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Comment body
		/// </summary>
		[JsonProperty("body")]	public  string Body { get ; set; }

		/// <summary>
		/// Checklist Item ID
		/// </summary>
		[JsonProperty("item_id")]	public  int? ItemId { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		[JsonProperty("created_by")]	public  CreatedBy CreatedBy { get ; set; }
	}
}
