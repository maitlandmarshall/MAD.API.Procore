using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.BIMModels.Models {
	public class BIMModel {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// BIM Model title.
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[JsonProperty("project_id")]	public  long? ProjectId { get ; set; }

		/// <summary>
		/// No. of model revisions published
		/// </summary>
		[JsonProperty("revisions_count")]	public  decimal? RevisionsCount { get ; set; }

		/// <summary>
		/// Deep link to Procore's Models Web Viewer.
		/// </summary>
		[JsonProperty("web_url")]	public  string WebUrl { get ; set; }

		/// <summary>
		/// Created date
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Updated date
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// Published BIM Model Revision
		/// </summary>
		[JsonProperty("current_revision")]	public  CurrentRevision CurrentRevision { get ; set; }
	}
}
