using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssues.Models {
	public class Viewpoint {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// ID of associated BIM File
		/// </summary>
		[JsonProperty("bim_file_id")]	public  long? BimFileId { get ; set; }

		/// <summary>
		/// ID of associated BIM View Folder
		/// </summary>
		[JsonProperty("view_folder_id")]	public  long? ViewFolderId { get ; set; }

		/// <summary>
		/// Created date
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Updated date
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

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
