using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Trade {

		/// <summary>
		/// Trade ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// Trade name
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }

		/// <summary>
		/// Trade availability
		/// </summary>
		[JsonProperty("active")]		public bool Active { get; set; }

		/// <summary>
		/// Timestamp of last update to Trade
		/// </summary>
		[JsonProperty("updated_at")]		public DateTimeOffset UpdatedAt { get; set; }
	}
}
