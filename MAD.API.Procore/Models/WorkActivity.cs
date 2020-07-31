using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class WorkActivity {

		/// <summary>
		/// Work Activity ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Work Activity Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Represents whether a Work Activity is available for use.
		/// </summary>
		[JsonProperty("active")]	public  bool Active { get ; set; }

		/// <summary>
		/// Represents whether a Work Activity has been provided by Procore.
		/// </summary>
		[JsonProperty("global")]	public  bool Global { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Date the work activity was updated
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }
	}
}
