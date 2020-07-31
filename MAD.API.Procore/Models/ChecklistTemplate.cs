using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistTemplate {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }

		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("description")]		public string Description { get; set; }

		/// <summary>
		/// Company level inspection template description
		/// </summary>
		[JsonProperty("company_description")]		public string CompanyDescription { get; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>
		/// Inspection Type
		/// </summary>
		[JsonProperty("inspection_type")]		public InspectionType InspectionType { get; set; }

		/// <summary>
		/// The ID of the associated Alternative Response Set (if null, the default response set is being used)
		/// </summary>
		[JsonProperty("alternative_response_set_id")]		public int? AlternativeResponseSetId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("response_set")]		public ChecklistDefaultResponseSet ResponseSet { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("trade")]		public Trade Trade { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("created_by")]		public CreatedBy CreatedBy { get; set; }

		/// <summary>
		/// Attachments
		/// </summary>
		[JsonProperty("attachments")]		public Attachments[] Attachments { get; set; }

		/// <summary>
		/// Checklist Sections
		/// </summary>
		[JsonProperty("sections")]		public Sections[] Sections { get; set; }
	}
}
