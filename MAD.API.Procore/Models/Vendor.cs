using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Vendor {

		/// <summary>
		/// Vendor ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Vendor Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
