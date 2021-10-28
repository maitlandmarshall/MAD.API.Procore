using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.BIMModels.Models {
	public class Rotation {

		/// <summary>
		/// x-axis coordinate
		/// </summary>
		[JsonProperty("x")]	public  decimal? X { get ; set; }

		/// <summary>
		/// y-axis coordinate
		/// </summary>
		[JsonProperty("y")]	public  decimal? Y { get ; set; }

		/// <summary>
		/// z-axis coordinate
		/// </summary>
		[JsonProperty("z")]	public  decimal? Z { get ; set; }
	}
}
