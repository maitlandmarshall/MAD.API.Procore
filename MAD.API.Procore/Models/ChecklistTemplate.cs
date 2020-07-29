using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ChecklistTemplate {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("company_description")]
		public string CompanyDescription { get; set; }
		[JsonProperty("created_at")]
		public DateTimeOffset CreatedAt { get; set; }
		[JsonProperty("updated_at")]
		public DateTimeOffset UpdatedAt { get; set; }
		[JsonProperty("inspection_type")]
		public JToken InspectionType { get; set; }
		[JsonProperty("alternative_response_set_id")]
		public int AlternativeResponseSetId { get; set; }
		[JsonProperty("response_set")]
		public ChecklistDefaultResponseSet ResponseSet { get; set; }
		[JsonProperty("trade")]
		public Trade Trade { get; set; }
		[JsonProperty("created_by")]
		public JToken CreatedBy { get; set; }
		[JsonProperty("attachments")]
		public JToken Attachments { get; set; }
		[JsonProperty("sections")]
		public JToken Sections { get; set; }
	}
}
