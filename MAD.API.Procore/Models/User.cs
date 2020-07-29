using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class User {
		[JsonProperty("address")]
		public string? Address { get; set; }
		[JsonProperty("avatar")]
		public string? Avatar { get; set; }
		[JsonProperty("business_phone")]
		public string? BusinessPhone { get; set; }
		[JsonProperty("business_phone_extension")]
		public int? BusinessPhoneExtension { get; set; }
		[JsonProperty("city")]
		public string? City { get; set; }
		[JsonProperty("country_code")]
		public string? CountryCode { get; set; }
		[JsonProperty("email_address")]
		public string? EmailAddress { get; set; }
		[JsonProperty("email_signature")]
		public string? EmailSignature { get; set; }
		[JsonProperty("employee_id")]
		public string? EmployeeId { get; set; }
		[JsonProperty("erp_integrated_accountant")]
		public bool ErpIntegratedAccountant { get; set; }
		[JsonProperty("fax_number")]
		public string? FaxNumber { get; set; }
		[JsonProperty("first_name")]
		public string? FirstName { get; set; }
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("initials")]
		public string? Initials { get; set; }
		[JsonProperty("is_active")]
		public bool? IsActive { get; set; }
		[JsonProperty("is_employee")]
		public bool? IsEmployee { get; set; }
		[JsonProperty("job_title")]
		public string? JobTitle { get; set; }
		[JsonProperty("last_login_at")]
		public DateTimeOffset? LastLoginAt { get; set; }
		[JsonProperty("last_name")]
		public string LastName { get; set; }
		[JsonProperty("mobile_phone")]
		public string? MobilePhone { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("notes")]
		public string? Notes { get; set; }
		[JsonProperty("state_code")]
		public string? StateCode { get; set; }
		[JsonProperty("welcome_email_sent_at")]
		public DateTimeOffset WelcomeEmailSentAt { get; set; }
		[JsonProperty("zip")]
		public string? Zip { get; set; }
		[JsonProperty("origin_id")]
		public string OriginId { get; set; }
		[JsonProperty("origin_data")]
		public string OriginData { get; set; }
		[JsonProperty("created_at")]
		public DateTimeOffset CreatedAt { get; set; }
		[JsonProperty("updated_at")]
		public DateTimeOffset UpdatedAt { get; set; }
		[JsonProperty("vendor")]
		public JToken Vendor { get; set; }
		[JsonProperty("default_permission_template_id")]
		public int? DefaultPermissionTemplateId { get; set; }
		[JsonProperty("permission_template")]
		public JToken PermissionTemplate { get; set; }
	}
}
