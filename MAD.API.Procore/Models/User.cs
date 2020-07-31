using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class User {

		/// <summary>
		/// User address
		/// </summary>
		[JsonProperty("address")]		public string? Address { get; set; }

		/// <summary>
		/// User avatar url
		/// </summary>
		[JsonProperty("avatar")]		public string? Avatar { get; set; }

		/// <summary>
		/// User business phone
		/// </summary>
		[JsonProperty("business_phone")]		public string? BusinessPhone { get; set; }

		/// <summary>
		/// User business phone extension
		/// </summary>
		[JsonProperty("business_phone_extension")]		public int? BusinessPhoneExtension { get; set; }

		/// <summary>
		/// User city
		/// </summary>
		[JsonProperty("city")]		public string? City { get; set; }

		/// <summary>
		/// User country code (ISO-3166 Alpha-2 format)
		/// </summary>
		[JsonProperty("country_code")]		public string? CountryCode { get; set; }

		/// <summary>
		/// User email
		/// </summary>
		[JsonProperty("email_address")]		public string? EmailAddress { get; set; }

		/// <summary>
		/// User email signature
		/// </summary>
		[JsonProperty("email_signature")]		public string? EmailSignature { get; set; }

		/// <summary>
		/// User employee id
		/// </summary>
		[JsonProperty("employee_id")]		public string? EmployeeId { get; set; }

		/// <summary>
		/// User erp integrated accountant status
		/// </summary>
		[JsonProperty("erp_integrated_accountant")]		public bool ErpIntegratedAccountant { get; set; }

		/// <summary>
		/// User fax number
		/// </summary>
		[JsonProperty("fax_number")]		public string? FaxNumber { get; set; }

		/// <summary>
		/// User first name
		/// </summary>
		[JsonProperty("first_name")]		public string? FirstName { get; set; }

		/// <summary>
		/// User id
		/// </summary>
		[JsonProperty("id")]		public int Id { get; set; }

		/// <summary>
		/// User initials
		/// </summary>
		[JsonProperty("initials")]		public string? Initials { get; set; }

		/// <summary>
		/// User active status
		/// </summary>
		[JsonProperty("is_active")]		public bool? IsActive { get; set; }

		/// <summary>
		/// User employee status
		/// </summary>
		[JsonProperty("is_employee")]		public bool? IsEmployee { get; set; }

		/// <summary>
		/// User job title
		/// </summary>
		[JsonProperty("job_title")]		public string? JobTitle { get; set; }

		/// <summary>
		/// User last login at
		/// </summary>
		[JsonProperty("last_login_at")]		public DateTimeOffset? LastLoginAt { get; set; }

		/// <summary>
		/// User last name
		/// </summary>
		[JsonProperty("last_name")]		public string LastName { get; set; }

		/// <summary>
		/// User mobile phone
		/// </summary>
		[JsonProperty("mobile_phone")]		public string? MobilePhone { get; set; }

		/// <summary>
		/// User full name
		/// </summary>
		[JsonProperty("name")]		public string Name { get; set; }

		/// <summary>
		/// User notes
		/// </summary>
		[JsonProperty("notes")]		public string? Notes { get; set; }

		/// <summary>
		/// User state code (ISO-3166 Alpha-2 format)
		/// </summary>
		[JsonProperty("state_code")]		public string? StateCode { get; set; }

		/// <summary>
		/// User welcome email sent at
		/// </summary>
		[JsonProperty("welcome_email_sent_at")]		public DateTimeOffset? WelcomeEmailSentAt { get; set; }

		/// <summary>
		/// User zip code
		/// </summary>
		[JsonProperty("zip")]		public string? Zip { get; set; }

		/// <summary>
		/// User origin id
		/// </summary>
		[JsonProperty("origin_id")]		public string OriginId { get; set; }

		/// <summary>
		/// User origin data
		/// </summary>
		[JsonProperty("origin_data")]		public string OriginData { get; set; }

		/// <summary>
		/// User created at
		/// </summary>
		[JsonProperty("created_at")]		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// User updated at
		/// </summary>
		[JsonProperty("updated_at")]		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("vendor")]		public Vendor Vendor { get; set; }

		/// <summary>
		/// User default permission template id
		/// </summary>
		[JsonProperty("default_permission_template_id")]		public int? DefaultPermissionTemplateId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("permission_template")]		public PermissionTemplate PermissionTemplate { get; set; }
	}
}
