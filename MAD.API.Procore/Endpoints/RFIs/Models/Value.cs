using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.RFIs.Models {
	public class Value {

		/// <summary>
		/// The unique identifier of the list of values (LOV) entry.
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Label of the list of values (LOV) entry.
		/// </summary>
		[JsonProperty("label")]	public  string Label { get ; set; }
	}
}
