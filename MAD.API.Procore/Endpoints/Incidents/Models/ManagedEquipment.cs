using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Incidents.Models {
	public class ManagedEquipment {

		/// <summary>
		/// Equipment ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Equipment name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
