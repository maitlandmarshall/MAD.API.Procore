using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Companies.Models {
	public class Company {

		/// <summary>
		/// Company id
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Company name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Company is active status
		/// </summary>
		[JsonProperty("is_active")]	public  bool IsActive { get ; set; }

		/// <summary>
		/// Company type
		/// </summary>
		[JsonProperty("company_type")]	public  string CompanyType { get ; set; }

		/// <summary>
		/// Company logo url
		/// </summary>
		[JsonProperty("logo_url")]	public  string LogoUrl { get ; set; }
	}
}
