using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssuePotentialAssignees.Models {
	public class CoordinationIssueAssignee {

		/// <summary>
		/// User ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Email associated with the user
		/// </summary>
		[JsonProperty("login")]	public  string Login { get ; set; }

		/// <summary>
		/// User's name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Associated company name
		/// </summary>
		[JsonProperty("company_name")]	public  string CompanyName { get ; set; }
	}
}
