using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Observations.Models {
	public class ObservationItemResponseLog {

		/// <summary>
		/// Response Log ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Observation Item ID
		/// </summary>
		[JsonProperty("item_id")]	public  long? ItemId { get ; set; }

		/// <summary>
		/// Response Log status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Response Log comment
		/// </summary>
		[JsonProperty("comment")]	public  string Comment { get ; set; }

		/// <summary>
		/// Date-time the Response Log was created
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Date-time the Response Log was last updated
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// User name
		/// </summary>
		[JsonProperty("created_by_name")]	public  string CreatedByName { get ; set; }

		/// <summary>
		/// Response Log Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<Attachment> Attachments { get ; set; }

		[JsonProperty("created_by")]	public  CreatedBy CreatedBy { get ; set; }
	}
}
