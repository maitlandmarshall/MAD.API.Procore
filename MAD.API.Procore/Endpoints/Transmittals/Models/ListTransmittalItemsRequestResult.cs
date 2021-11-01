using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Transmittals.Models {
	public class ListTransmittalItemsRequestResult {

		/// <summary>
		/// Number of copies
		/// </summary>
		[JsonProperty("copies")]	public  int? Copies { get ; set; }

		/// <summary>
		/// Created date
		/// </summary>
		[JsonProperty("created_at")]	public  string CreatedAt { get ; set; }

		/// <summary>
		/// Date
		/// </summary>
		[JsonProperty("date")]	public  string Date { get ; set; }

		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		[JsonProperty("item")]	public  ListTransmittalItemsRequestResultItem Item { get ; set; }

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Attachment Type
		/// </summary>
		[JsonProperty("attachment_type")]	public  string AttachmentType { get ; set; }
	}
}
