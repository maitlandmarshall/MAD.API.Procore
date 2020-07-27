namespace MAD.API.Procore.Models
{
    using System;
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class ManpowerLog
    {
        [J("id")] public long Id { get; set; }
        [J("created_at")] public DateTimeOffset CreatedAt { get; set; }
        [J("date")] public DateTimeOffset Date { get; set; }
        [J("datetime")] public DateTimeOffset Datetime { get; set; }
        [J("deleted_at")] public DateTimeOffset? DeletedAt { get; set; }
        [J("man_hours")] public string ManHours { get; set; }
        [J("notes")] public string Notes { get; set; }
        [J("num_workers")] public long? NumWorkers { get; set; }
        [J("num_hours")] public string NumHours { get; set; }
        [J("position")] public long? Position { get; set; }
        [J("status")] public string Status { get; set; }
        [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
        [J("vendor")] public CostCodeModel Vendor { get; set; }
        [J("user")] public CreatedByModel User { get; set; }
        [J("contact")] public ContactModel Contact { get; set; }
        [J("cost_code")] public CostCodeModel CostCode { get; set; }
        [J("created_by")] public CreatedByModel CreatedBy { get; set; }
        [J("location")] public LocationModel Location { get; set; }
        [J("attachments")] public AttachmentModel[] Attachments { get; set; }
        [J("trade")] public TradeModel Trade { get; set; }

        public partial class AttachmentModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("url")] public string Url { get; set; }
            [J("filename")] public string Filename { get; set; }
        }

        public partial class ContactModel
        {
            [J("id")] public long Id { get; set; }
            [J("business_phone")] public string BusinessPhone { get; set; }
            [J("business_phone_extension")] public long? BusinessPhoneExtension { get; set; }
            [J("email")] public string Email { get; set; }
            [J("fax_number")] public string FaxNumber { get; set; }
            [J("job_title")] public string JobTitle { get; set; }
            [J("login_information_id")] public string LoginInformationId { get; set; }
            [J("mobile_phone")] public string MobilePhone { get; set; }
            [J("name")] public string Name { get; set; }
            [J("vendor_name")] public string VendorName { get; set; }
        }

        public partial class CostCodeModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
        }

        public partial class CreatedByModel
        {
            [J("id")] public long Id { get; set; }
            [J("login")] public string Login { get; set; }
            [J("name")] public string Name { get; set; }
        }

        public partial class LocationModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("node_name")] public string NodeName { get; set; }
            [J("parent_id")] public long? ParentId { get; set; }
            [J("created_at")] public DateTimeOffset CreatedAt { get; set; }
            [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
        }

        public partial class TradeModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("active")] public bool Active { get; set; }
            [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
        }
    }
}
