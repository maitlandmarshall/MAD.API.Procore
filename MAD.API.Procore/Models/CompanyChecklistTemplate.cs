using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class CompanyChecklistTemplate {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		[JsonProperty("inspection_type")]	public  InspectionType InspectionType { get ; set; }

		[JsonProperty("trade")]	public  Trade Trade { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// The ID of the associated Alternative Response Set (if null, the default response set is being used)
		/// </summary>
		[JsonProperty("alternative_response_set_id")]	public  long? AlternativeResponseSetId { get ; set; }

		[JsonProperty("created_by")]	public  CreatedBy CreatedBy { get ; set; }

		/// <summary>
		/// Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<Attachment> Attachments { get ; set; }

		[JsonProperty("response_set")]	public  ChecklistDefaultResponseSet ResponseSet { get ; set; }

		/// <summary>
		/// Sections
		/// </summary>
		[JsonProperty("sections")]	public  List<Section> Sections { get ; set; }
	}
}
