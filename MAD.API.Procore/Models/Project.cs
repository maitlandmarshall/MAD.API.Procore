using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Project {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("display_name")]
		public string DisplayName { get; set; }
		[JsonProperty("project_number")]
		public string ProjectNumber { get; set; }
		[JsonProperty("address")]
		public string Address { get; set; }
		[JsonProperty("city")]
		public string City { get; set; }
		[JsonProperty("state_code")]
		public string StateCode { get; set; }
		[JsonProperty("country_code")]
		public string CountryCode { get; set; }
		[JsonProperty("zip")]
		public string Zip { get; set; }
		[JsonProperty("county")]
		public string County { get; set; }
		[JsonProperty("latitude")]
		public decimal Latitude { get; set; }
		[JsonProperty("longitude")]
		public decimal Longitude { get; set; }
		[JsonProperty("stage")]
		public string Stage { get; set; }
		[JsonProperty("phone")]
		public string Phone { get; set; }
		[JsonProperty("created_at")]
		public DateTimeOffset CreatedAt { get; set; }
		[JsonProperty("updated_at")]
		public DateTimeOffset UpdatedAt { get; set; }
		[JsonProperty("active")]
		public bool Active { get; set; }
		[JsonProperty("origin_id")]
		public string OriginId { get; set; }
		[JsonProperty("origin_data")]
		public string OriginData { get; set; }
		[JsonProperty("origin_code")]
		public string OriginCode { get; set; }
		[JsonProperty("estimated_value")]
		public decimal EstimatedValue { get; set; }
		[JsonProperty("project_region_id")]
		public int ProjectRegionId { get; set; }
		[JsonProperty("project_bid_type_id")]
		public int ProjectBidTypeId { get; set; }
		[JsonProperty("project_owner_type_id")]
		public int ProjectOwnerTypeId { get; set; }
		[JsonProperty("photo_id")]
		public int PhotoId { get; set; }
		[JsonProperty("company")]
		public ProjectCompany Company { get; set; }
	}
}
