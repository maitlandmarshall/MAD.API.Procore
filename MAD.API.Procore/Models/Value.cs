using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Value {

		/// <summary>
		/// ID of the LOV Entry
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Label of the LOV Entry
		/// </summary>
		[JsonProperty("label")]	public  string Label { get ; set; }
	}
}
