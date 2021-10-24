using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Models
{
    public class Project
    {

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Project display name
        /// </summary>
        [JsonProperty("display_name")] public string DisplayName { get; set; }

        /// <summary>
        /// Project number
        /// </summary>
        [JsonProperty("project_number")] public string ProjectNumber { get; set; }

        /// <summary>
        /// Project address
        /// </summary>
        [JsonProperty("address")] public string Address { get; set; }

        /// <summary>
        /// Project city
        /// </summary>
        [JsonProperty("city")] public string City { get; set; }

        /// <summary>
        /// Project state code (ISO-3166 Alpha-2 format)
        /// </summary>
        [JsonProperty("state_code")] public string StateCode { get; set; }

        /// <summary>
        /// Project country code (ISO-3166 Alpha-2 format)
        /// </summary>
        [JsonProperty("country_code")] public string CountryCode { get; set; }

        /// <summary>
        /// Project zip code
        /// </summary>
        [JsonProperty("zip")] public string Zip { get; set; }

        /// <summary>
        /// Project county
        /// </summary>
        [JsonProperty("county")] public string County { get; set; }

        /// <summary>
        /// Project latitude
        /// </summary>
        [JsonProperty("latitude")] public decimal? Latitude { get; set; }

        /// <summary>
        /// Project longitude
        /// </summary>
        [JsonProperty("longitude")] public decimal? Longitude { get; set; }

        /// <summary>
        /// Project stage name
        /// </summary>
        [JsonProperty("stage")] public string Stage { get; set; }

        /// <summary>
        /// Project phone
        /// </summary>
        [JsonProperty("phone")] public string Phone { get; set; }

        /// <summary>
        /// Project created at
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Project updated at
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Project active status
        /// </summary>
        [JsonProperty("active")] public bool Active { get; set; }

        /// <summary>
        /// Project third party id
        /// </summary>
        [JsonProperty("origin_id")] public string OriginId { get; set; }

        /// <summary>
        /// Project third party data
        /// </summary>
        [JsonProperty("origin_data")] public string OriginData { get; set; }

        /// <summary>
        /// Project third party code
        /// </summary>
        [JsonProperty("origin_code")] public string OriginCode { get; set; }

        /// <summary>
        /// The Estimated Value of the Project
        /// </summary>
        [JsonProperty("estimated_value")] public decimal? EstimatedValue { get; set; }

        /// <summary>
        /// Project Region ID
        /// </summary>
        [JsonProperty("project_region_id")] public int? ProjectRegionId { get; set; }

        /// <summary>
        /// Project Bid Type ID
        /// </summary>
        [JsonProperty("project_bid_type_id")] public int? ProjectBidTypeId { get; set; }

        /// <summary>
        /// Project Owner Type ID
        /// </summary>
        [JsonProperty("project_owner_type_id")] public int? ProjectOwnerTypeId { get; set; }

        /// <summary>
        /// Project Photo Id
        /// </summary>
        [JsonProperty("photo_id")] public int? PhotoId { get; set; }

        [JsonProperty("company")] public ProjectCompany Company { get; set; }
    }
}
