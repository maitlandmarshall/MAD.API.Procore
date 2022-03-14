using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ProjectPeople.Models {
	public class ProjectPerson {

		/// <summary>
		/// The Contact associated with the Project Person
		/// </summary>
		[JsonProperty("contact")]	public  ProjectPersonContact Contact { get ; set; }

		/// <summary>
		/// Employee ID for the Project Person
		/// </summary>
		[JsonProperty("employee_id")]	public  string EmployeeId { get ; set; }

		/// <summary>
		/// Project Person first name
		/// </summary>
		[JsonProperty("first_name")]	public  string FirstName { get ; set; }

		/// <summary>
		/// Unique identifier for the Project Person.
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Employee status for the Project Person
		/// </summary>
		[JsonProperty("is_employee")]	public  bool? IsEmployee { get ; set; }

		/// <summary>
		/// Project Person last name
		/// </summary>
		[JsonProperty("last_name")]	public  string LastName { get ; set; }

		/// <summary>
		/// User ID if this Project Person represents a User. NULL for a Reference user. User.
		/// </summary>
		[JsonProperty("user_id")]	public  long? UserId { get ; set; }

		/// <summary>
		/// Work Classification ID for the Project Person
		/// </summary>
		[JsonProperty("work_classification_id")]	public  long? WorkClassificationId { get ; set; }
	}
}
