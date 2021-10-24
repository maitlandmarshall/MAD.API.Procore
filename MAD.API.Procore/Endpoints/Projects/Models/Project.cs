using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
namespace MAD.API.Procore.Endpoints.Projects.Models
{
    public class Project
    {
        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// The name of the Project
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// The display name for the Project
        /// </summary>
        [JsonProperty("display_name")] public string DisplayName { get; set; }

        /// <summary>
        /// The Project number
        /// </summary>
        [JsonProperty("project_number")] public string ProjectNumber { get; set; }

        /// <summary>
        /// The street address for the Project
        /// </summary>
        [JsonProperty("address")] public string Address { get; set; }

        /// <summary>
        /// The city in which the Project is located
        /// </summary>
        [JsonProperty("city")] public string City { get; set; }

        /// <summary>
        /// The state code for the Project (ISO-3166 Alpha-2 format)
        /// </summary>
        [JsonProperty("state_code")] public string StateCode { get; set; }

        /// <summary>
        /// The country code for the Project (ISO-3166 Alpha-2 format)
        /// </summary>
        [JsonProperty("country_code")] public string CountryCode { get; set; }

        /// <summary>
        /// The postal code for the Project
        /// </summary>
        [JsonProperty("zip")] public string Zip { get; set; }

        /// <summary>
        /// The county in which the Project is located
        /// </summary>
        [JsonProperty("county")] public string County { get; set; }

        /// <summary>
        /// The geographic coordinate that specifies the north–south position of the Project on the Earth's surface.
        /// </summary>
        [JsonProperty("latitude")] public decimal? Latitude { get; set; }

        /// <summary>
        /// The geographic coordinate that specifies the east–west position of the Project on the Earth's surface.
        /// </summary>
        [JsonProperty("longitude")] public decimal? Longitude { get; set; }

        /// <summary>
        /// The name of the Project stage
        /// </summary>
        [JsonProperty("stage")] public string Stage { get; set; }

        /// <summary>
        /// The telephone number for the Project
        /// </summary>
        [JsonProperty("phone")] public string Phone { get; set; }

        /// <summary>
        /// The date and time the Project was created
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The date and time the Project was last updated
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// The active status for the Project
        /// </summary>
        [JsonProperty("active")] public bool Active { get; set; }

        /// <summary>
        /// An external third-party identifier for the Project
        /// </summary>
        [JsonProperty("origin_id")] public string OriginId { get; set; }

        /// <summary>
        /// An external third-party data string associated with the Project
        /// </summary>
        [JsonProperty("origin_data")] public string OriginData { get; set; }

        /// <summary>
        /// An external third-party code associated with the Project
        /// </summary>
        [JsonProperty("origin_code")] public string OriginCode { get; set; }

        /// <summary>
        /// A linked identifier for the Owner's Project
        /// </summary>
        [JsonProperty("owners_project_id")] public long? OwnersProjectId { get; set; }

        /// <summary>
        /// The total amount of construction work performed, planned, or put in place during the project. Note: this field is a replacement to estimated_value and will mirror its value.
        /// </summary>
        [JsonProperty("total_value")] public decimal? TotalValue { get; set; }

        /// <summary>
        /// The store number for the Project
        /// </summary>
        [JsonProperty("store_number")] public string StoreNumber { get; set; }

        /// <summary>
        /// The accounting project number for the Project
        /// </summary>
        [JsonProperty("accounting_project_number")] public string AccountingProjectNumber { get; set; }

        /// <summary>
        /// The designated market area the Project is located in
        /// </summary>
        [JsonProperty("designated_market_area")] public string DesignatedMarketArea { get; set; }

        /// <summary>
        /// The region identifier for the Project
        /// </summary>
        [JsonProperty("project_region_id")] public long? ProjectRegionId { get; set; }

        /// <summary>
        /// The Bid Type identifier for the Project
        /// </summary>
        [JsonProperty("project_bid_type_id")] public long? ProjectBidTypeId { get; set; }

        /// <summary>
        /// The Owner Type identifier for the Project
        /// </summary>
        [JsonProperty("project_owner_type_id")] public long? ProjectOwnerTypeId { get; set; }

        /// <summary>
        /// The unique identifier for the Project Photo
        /// </summary>
        [JsonProperty("photo_id")] public long? PhotoId { get; set; }

        /// <summary>
        /// The start date for the project
        /// </summary>
        [JsonProperty("start_date")] public string StartDate { get; set; }

        /// <summary>
        /// The completion date for the project
        /// </summary>
        [JsonProperty("completion_date")] public string CompletionDate { get; set; }

        /// <summary>
        /// The Estimated Value of the project. Note: this field is now deprecated and will mirror the value of total_value until it is no longer supported.
        /// </summary>
        [JsonProperty("estimated_value")] public decimal? EstimatedValue { get; set; }

        [JsonProperty("company")] public ProjectCompany Company { get; set; }

        [JsonProperty("custom_fields")] public JObject CustomFields { get; set; }
    }
}
