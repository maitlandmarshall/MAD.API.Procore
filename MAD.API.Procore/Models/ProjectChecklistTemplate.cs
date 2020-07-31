using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ProjectChecklistTemplate {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  int Id { get ; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Company Description
		/// </summary>
		[JsonProperty("company_description")]	public  string CompanyDescription { get ; set; }

		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		[JsonProperty("inspection_type")]	public  InspectionType InspectionType { get ; set; }

		[JsonProperty("trade")]	public  Trade Trade { get ; set; }

		[JsonProperty("synced_to")]	public  SyncedTo SyncedTo { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }
	}
}
