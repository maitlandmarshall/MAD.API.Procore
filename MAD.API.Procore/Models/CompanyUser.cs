namespace MAD.API.Procore.Models
{
    using System;
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class CompanyUser
    {
        [J("address")] public string Address { get; set; }
        [J("avatar")] public Uri? Avatar { get; set; }
        [J("business_phone")] public string BusinessPhone { get; set; }
        [J("business_phone_extension")] public string BusinessPhoneExtension { get; set; }
        [J("city")] public string City { get; set; }
        [J("country_code")] public string CountryCode { get; set; }
        [J("email_address")] public string EmailAddress { get; set; }
        [J("email_signature")] public string EmailSignature { get; set; }
        [J("employee_id")] public string EmployeeId { get; set; }
        [J("erp_integrated_accountant")] public bool ErpIntegratedAccountant { get; set; }
        [J("fax_number")] public string FaxNumber { get; set; }
        [J("first_name")] public string FirstName { get; set; }
        [J("id")] public long? Id { get; set; }
        [J("initials")] public string Initials { get; set; }
        [J("is_active")] public bool IsActive { get; set; }
        [J("is_employee")] public bool IsEmployee { get; set; }
        [J("job_title")] public string JobTitle { get; set; }
        [J("last_login_at")] public DateTimeOffset? LastLoginAt { get; set; }
        [J("last_name")] public string LastName { get; set; }
        [J("mobile_phone")] public string MobilePhone { get; set; }
        [J("name")] public string Name { get; set; }
        [J("notes")] public string Notes { get; set; }
        [J("state_code")] public string StateCode { get; set; }
        [J("welcome_email_sent_at")] public DateTimeOffset? WelcomeEmailSentAt { get; set; }
        [J("zip")] public string Zip { get; set; }
        [J("origin_id")] public string OriginId { get; set; }
        [J("origin_data")] public string OriginData { get; set; }
        [J("created_at")] public DateTimeOffset CreatedAt { get; set; }
        [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
        [J("vendor")] public VendorModel Vendor { get; set; }
        [J("default_permission_template_id")] public long? DefaultPermissionTemplateId { get; set; }
        [J("permission_template")] public PermissionTemplateModel PermissionTemplate { get; set; }

        public partial class PermissionTemplateModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("project_specific")] public bool ProjectSpecific { get; set; }
        }

        public partial class VendorModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
        }
    }
}
