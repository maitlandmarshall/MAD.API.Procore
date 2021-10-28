using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.BIMModels.Models {
	public class BimGridline {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Filename
		/// </summary>
		[JsonProperty("filename")]	public  string Filename { get ; set; }

		/// <summary>
		/// Coordinate system used in exporting gridlines
		/// </summary>
		[JsonProperty("coordinate_system")]	public  string CoordinateSystem { get ; set; }

		/// <summary>
		/// Created date
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Updated date
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		[JsonProperty("gridline_file")]	public  GridlineFile GridlineFile { get ; set; }
	}
}
