using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ChecklistTemplates.Models {
	public class ChecklistTemplate {

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

		/// <summary>
		/// Company level inspection template description
		/// </summary>
		[JsonProperty("company_description")]	public  string CompanyDescription { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// Inspection Type
		/// </summary>
		[JsonProperty("inspection_type")]	public  ChecklistTemplateInspectionType InspectionType { get ; set; }

		/// <summary>
		/// The ID of the associated Alternative Response Set (if null, the default response set is being used)
		/// </summary>
		[JsonProperty("alternative_response_set_id")]	public  long? AlternativeResponseSetId { get ; set; }

		[JsonProperty("response_set")]	public  ChecklistDefaultResponseSet ResponseSet { get ; set; }

		[JsonProperty("location")]	public  ChecklistTemplateLocation Location { get ; set; }

		[JsonProperty("trade")]	public  Trade Trade { get ; set; }

		[JsonProperty("created_by")]	public  ChecklistTemplateCreatedBy CreatedBy { get ; set; }

		/// <summary>
		/// Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<ChecklistTemplateAttachment> Attachments { get ; set; }

		/// <summary>
		/// Checklist Sections
		/// </summary>
		[JsonProperty("sections")]	public  List<ChecklistTemplateSection> Sections { get ; set; }
	}
}
