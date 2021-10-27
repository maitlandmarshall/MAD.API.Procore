using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Incidents.Models {
	public class AfflictionType {

		/// <summary>
		/// Affliction Type ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Affliction Type Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Represents whether a Affliction Type is available for use.
		/// </summary>
		[JsonProperty("active")]	public  bool Active { get ; set; }

		/// <summary>
		/// Represents whether a Affliction Type has been provided by Procore.
		/// </summary>
		[JsonProperty("global")]	public  bool Global { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }
	}
}
