namespace MAD.API.Procore.Models
{
    using System;
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class Project
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("display_name")] public string DisplayName { get; set; }
        [J("project_number")] public string ProjectNumber { get; set; }
        [J("address")] public string Address { get; set; }
        [J("city")] public string City { get; set; }
        [J("state_code")] public string StateCode { get; set; }
        [J("country_code")] public string CountryCode { get; set; }
        [J("zip")] public string Zip { get; set; }
        [J("county")] public string County { get; set; }
        [J("latitude")] public double? Latitude { get; set; }
        [J("longitude")] public double? Longitude { get; set; }
        [J("stage")] public string Stage { get; set; }
        [J("phone")] public string Phone { get; set; }
        [J("created_at")] public DateTimeOffset CreatedAt { get; set; }
        [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
        [J("active")] public bool Active { get; set; }
        [J("origin_id")] public string OriginId { get; set; }
        [J("origin_data")] public string OriginData { get; set; }
        [J("origin_code")] public string OriginCode { get; set; }
        [J("owners_project_id")] public long? OwnersProjectId { get; set; }
        [J("total_value")] public long? TotalValue { get; set; }
        [J("project_region_id")] public long? ProjectRegionId { get; set; }
        [J("project_bid_type_id")] public long? ProjectBidTypeId { get; set; }
        [J("project_owner_type_id")] public long? ProjectOwnerTypeId { get; set; }
        [J("photo_id")] public long? PhotoId { get; set; }
        [J("start_date")] public DateTimeOffset? StartDate { get; set; }
        [J("completion_date")] public DateTimeOffset? CompletionDate { get; set; }
        [J("estimated_value")] public long? EstimatedValue { get; set; }
        [J("company")] public CompanyModel Company { get; set; }

        public partial class CompanyModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
        }
    }
}
