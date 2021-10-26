using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Projects.Models {
	public class ProjectPersistentMessage {

		/// <summary>
		/// The title of the persistent message for the Project
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// The text content for the Project persistent message
		/// </summary>
		[JsonProperty("message")]	public  string Message { get ; set; }
	}
}
