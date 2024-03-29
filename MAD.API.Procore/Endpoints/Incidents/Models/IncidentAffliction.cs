using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Incidents.Models {
	public class IncidentAffliction {

		/// <summary>
		/// Affliction ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("affliction_type")]	public  AfflictionType AfflictionType { get ; set; }

		/// <summary>
		/// The body part affected by the affliction
		/// </summary>
		[JsonProperty("affected_body_part")]	public  string AffectedBodyPart { get ; set; }
	}
}
