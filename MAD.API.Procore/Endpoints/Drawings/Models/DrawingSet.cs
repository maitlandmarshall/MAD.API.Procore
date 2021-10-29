using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Drawings.Models {
	public class DrawingSet {

		/// <summary>
		/// Drawing Set ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }
	}
}
