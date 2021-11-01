using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Transmittals.Models {
	public class ListTransmittalItemsRequestResultItem {

		/// <summary>
		/// The ID for the item if it is an associated Procore record
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The internal Procore record type, if applicable
		/// </summary>
		[JsonProperty("type")]	public  string Type { get ; set; }

		/// <summary>
		/// The date for the related item
		/// </summary>
		[JsonProperty("date")]	public  DateTimeOffset? Date { get ; set; }

		/// <summary>
		/// The relative URL for the related resource if available. If this is an attachment, it will be the URL to download the attachment. If it is a procore record, it will be the link the resource's API endpoint.
		/// </summary>
		[JsonProperty("url")]	public  string Url { get ; set; }
	}
}
