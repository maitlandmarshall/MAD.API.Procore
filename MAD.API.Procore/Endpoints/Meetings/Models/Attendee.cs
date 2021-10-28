using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Meetings.Models {
	public class Attendee {

		/// <summary>
		/// Attendee id
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Attendee status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		[JsonProperty("login_information")]	public  LoginInformation LoginInformation { get ; set; }
	}
}
