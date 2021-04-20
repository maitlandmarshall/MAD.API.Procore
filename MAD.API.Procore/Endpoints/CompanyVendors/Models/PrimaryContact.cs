using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CompanyVendors.Models {
	public class PrimaryContact {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// First name
		/// </summary>
		[JsonProperty("first_name")]	public  string FirstName { get ; set; }

		/// <summary>
		/// Last name
		/// </summary>
		[JsonProperty("last_name")]	public  string LastName { get ; set; }

		/// <summary>
		/// Business phone
		/// </summary>
		[JsonProperty("business_phone")]	public  string BusinessPhone { get ; set; }

		/// <summary>
		/// Business phone extension
		/// </summary>
		[JsonProperty("business_phone_extension")]	public  int? BusinessPhoneExtension { get ; set; }

		/// <summary>
		/// Fax number
		/// </summary>
		[JsonProperty("fax_number")]	public  string FaxNumber { get ; set; }

		/// <summary>
		/// Mobile phone
		/// </summary>
		[JsonProperty("mobile_phone")]	public  string MobilePhone { get ; set; }

		/// <summary>
		/// Email
		/// </summary>
		[JsonProperty("email_address")]	public  string EmailAddress { get ; set; }

		/// <summary>
		/// Created at
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Updated at
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }
	}
}
