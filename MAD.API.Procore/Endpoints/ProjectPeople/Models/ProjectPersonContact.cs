using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ProjectPeople.Models {
	public class ProjectPersonContact {

		/// <summary>
		/// The active status of the Contact associated with the Project Person
		/// </summary>
		[JsonProperty("is_active")]	public  bool? IsActive { get ; set; }
	}
}
