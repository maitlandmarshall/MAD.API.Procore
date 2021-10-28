using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Drawings.Models {
	public class DrawingArea {

		/// <summary>
		/// Drawing Area ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }
	}
}
