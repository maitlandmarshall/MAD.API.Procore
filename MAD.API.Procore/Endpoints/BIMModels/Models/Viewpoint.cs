using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.BIMModels.Models {
	public class Viewpoint {

		[JsonProperty("snapshot")]	public  Snapshot Snapshot { get ; set; }

		/// <summary>
		/// Viewpoint name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// JSON string for camera data for the building model associated with the issue
		/// </summary>
		[JsonProperty("camera_data")]	public  string CameraData { get ; set; }

		/// <summary>
		/// JSON string for lines data for the building model associated with the issue
		/// </summary>
		[JsonProperty("redlines_data")]	public  string RedlinesData { get ; set; }

		/// <summary>
		/// JSON string for cliping plane data for the building model associated with the issue
		/// </summary>
		[JsonProperty("sections_data")]	public  string SectionsData { get ; set; }
	}
}
