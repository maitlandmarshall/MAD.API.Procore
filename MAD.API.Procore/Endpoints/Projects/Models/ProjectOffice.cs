using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Projects.Models {
	public class ProjectOffice {

		/// <summary>
		/// The identifier for the Office
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The name for the Office
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Office address
		/// </summary>
		[JsonProperty("address")]	public  string Address { get ; set; }

		/// <summary>
		/// Office city
		/// </summary>
		[JsonProperty("city")]	public  string City { get ; set; }

		/// <summary>
		/// Office state code (ISO-3166 Alpha-2 format)
		/// </summary>
		[JsonProperty("state_code")]	public  string StateCode { get ; set; }

		/// <summary>
		/// Office country code (ISO-3166 Alpha-2 format)
		/// </summary>
		[JsonProperty("country_code")]	public  string CountryCode { get ; set; }

		/// <summary>
		/// Office zip
		/// </summary>
		[JsonProperty("zip")]	public  string Zip { get ; set; }

		/// <summary>
		/// Office phone
		/// </summary>
		[JsonProperty("phone")]	public  string Phone { get ; set; }

		/// <summary>
		/// Office fax
		/// </summary>
		[JsonProperty("fax")]	public  string Fax { get ; set; }

		/// <summary>
		/// Office division
		/// </summary>
		[JsonProperty("division")]	public  string Division { get ; set; }

		[JsonProperty("logo")]	public  Logo Logo { get ; set; }
	}
}
