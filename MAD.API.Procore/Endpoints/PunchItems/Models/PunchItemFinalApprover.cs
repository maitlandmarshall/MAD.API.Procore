using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.PunchItems.Models {
	public class PunchItemFinalApprover {

		/// <summary>
		/// User ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// User Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// User Email
		/// </summary>
		[JsonProperty("login")]	public  string Login { get ; set; }
	}
}
