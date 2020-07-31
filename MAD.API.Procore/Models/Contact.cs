using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Contact {

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("business_phone")]		public string BusinessPhone { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("business_phone_extension")]		public int? BusinessPhoneExtension { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("email")]		public string Email { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("fax_number")]		public string? FaxNumber { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("job_title")]		public string? JobTitle { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("login_information_id")]		public int? LoginInformationId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("mobile_phone")]		public string MobilePhone { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("vendor_name")]		public string VendorName { get; set; }
	}
}
