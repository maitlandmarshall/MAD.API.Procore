using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ProjectPerson {
		[JsonProperty("contact")]
		public JToken Contact { get; set; }
		[JsonProperty("employee_id")]
		public string? EmployeeId { get; set; }
		[JsonProperty("first_name")]
		public string FirstName { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("is_employee")]
		public bool? IsEmployee { get; set; }
		[JsonProperty("last_name")]
		public string LastName { get; set; }
		[JsonProperty("user_id")]
		public int? UserId { get; set; }
		[JsonProperty("work_classification_id")]
		public int? WorkClassificationId { get; set; }
	}
}
