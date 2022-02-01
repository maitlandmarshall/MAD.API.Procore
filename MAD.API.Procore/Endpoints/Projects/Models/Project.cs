using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Projects.Models {
	public class Project {

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The URL for the Project logo
		/// </summary>
		[JsonProperty("logo_url")]	public  string LogoUrl { get ; set; }

		/// <summary>
		/// The name for the Project
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// The display name for the Project
		/// </summary>
		[JsonProperty("display_name")]	public  string DisplayName { get ; set; }

		/// <summary>
		/// The Project number
		/// </summary>
		[JsonProperty("project_number")]	public  string ProjectNumber { get ; set; }

		/// <summary>
		/// The street address for the Project
		/// </summary>
		[JsonProperty("address")]	public  string Address { get ; set; }

		/// <summary>
		/// The city in which the Project is located
		/// </summary>
		[JsonProperty("city")]	public  string City { get ; set; }

		/// <summary>
		/// The state code for the Project (ISO-3166 Alpha-2 format)
		/// </summary>
		[JsonProperty("state_code")]	public  string StateCode { get ; set; }

		/// <summary>
		/// The country code for the Project (ISO-3166 Alpha-2 format)
		/// </summary>
		[JsonProperty("country_code")]	public  string CountryCode { get ; set; }

		/// <summary>
		/// The postal code for the Project
		/// </summary>
		[JsonProperty("zip")]	public  string Zip { get ; set; }

		/// <summary>
		/// The timezone in which the Project is located
		/// </summary>
		[JsonProperty("time_zone")]	public  string TimeZone { get ; set; }

		/// <summary>
		/// The tz-database version of the timezone for the Project
		/// </summary>
		[JsonProperty("tz_name")]	public  string TzName { get ; set; }

		/// <summary>
		/// The geographic coordinate that specifies the north–south position of the Project on the Earth's surface.
		/// </summary>
		[JsonProperty("latitude")]	public  decimal? Latitude { get ; set; }

		/// <summary>
		/// The geographic coordinate that specifies the east–west position of the Project on the Earth's surface.
		/// </summary>
		[JsonProperty("longitude")]	public  decimal? Longitude { get ; set; }

		/// <summary>
		/// The county in which the Project is located
		/// </summary>
		[JsonProperty("county")]	public  string County { get ; set; }

		/// <summary>
		/// Unique identifier for the Parent Job
		/// </summary>
		[JsonProperty("parent_job_id")]	public  long? ParentJobId { get ; set; }

		/// <summary>
		/// Project description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// The total square footage for the Project
		/// </summary>
		[JsonProperty("square_feet")]	public  long? SquareFeet { get ; set; }

		/// <summary>
		/// The date that the contract for the project is signed. Note: this field is a replacement to estimated_start_date and will mirror its value.
		/// </summary>
		[JsonProperty("start_date")]	public  string StartDate { get ; set; }

		/// <summary>
		/// The date that all parties agree the project meets or must meet “substantial completion”. Note: this field is a replacement to estimated_completion_date and will mirror its value.
		/// </summary>
		[JsonProperty("completion_date")]	public  string CompletionDate { get ; set; }

		/// <summary>
		/// The total amount of construction work performed, planned, or put in place during the project. Note: this field is a replacement to estimated_value and will mirror its value.
		/// </summary>
		[JsonProperty("total_value")]	public  decimal? TotalValue { get ; set; }

		/// <summary>
		/// The store number for the Project
		/// </summary>
		[JsonProperty("store_number")]	public  string StoreNumber { get ; set; }

		/// <summary>
		/// The accounting project number for the Project
		/// </summary>
		[JsonProperty("accounting_project_number")]	public  string AccountingProjectNumber { get ; set; }

		/// <summary>
		/// The designated market area the Project is located in
		/// </summary>
		[JsonProperty("designated_market_area")]	public  string DesignatedMarketArea { get ; set; }

		/// <summary>
		/// The start date for the Project Warranty
		/// </summary>
		[JsonProperty("warranty_start_date")]	public  string WarrantyStartDate { get ; set; }

		/// <summary>
		/// The end date for the Project Warranty
		/// </summary>
		[JsonProperty("warranty_end_date")]	public  string WarrantyEndDate { get ; set; }

		/// <summary>
		/// The active status for the Project
		/// </summary>
		[JsonProperty("active")]	public  bool? Active { get ; set; }

		/// <summary>
		/// The Project flag (Red, Yellow, or Green)
		/// </summary>
		[JsonProperty("flag")]	public  string Flag { get ; set; }

		/// <summary>
		/// The telephone number for the Project
		/// </summary>
		[JsonProperty("phone")]	public  string Phone { get ; set; }

		/// <summary>
		/// Public notes on the Project
		/// </summary>
		[JsonProperty("public_notes")]	public  string PublicNotes { get ; set; }

		/// <summary>
		/// The actual start date for the Project
		/// </summary>
		[JsonProperty("actual_start_date")]	public  string ActualStartDate { get ; set; }

		/// <summary>
		/// The projected finish date for the Project
		/// </summary>
		[JsonProperty("projected_finish_date")]	public  string ProjectedFinishDate { get ; set; }

		/// <summary>
		/// The date and time the Project was created
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset? CreatedAt { get ; set; }

		/// <summary>
		/// The date and time the Project was last updated
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset? UpdatedAt { get ; set; }

		/// <summary>
		/// An external third-party identifier for the Project
		/// </summary>
		[JsonProperty("origin_id")]	public  string OriginId { get ; set; }

		/// <summary>
		/// An external third-party data string associated with the Project
		/// </summary>
		[JsonProperty("origin_data")]	public  string OriginData { get ; set; }

		/// <summary>
		/// An external third-party code associated with the Project
		/// </summary>
		[JsonProperty("origin_code")]	public  string OriginCode { get ; set; }

		[JsonProperty("standard_cost_code_list_id")]	public  long? StandardCostCodeListId { get ; set; }

		/// <summary>
		/// True if project is ERP integrated
		/// </summary>
		[JsonProperty("is_erp_integrated")]	public  bool? IsErpIntegrated { get ; set; }

		/// <summary>
		/// A linked identifier for the Owner's Project
		/// </summary>
		[JsonProperty("owners_project_id")]	public  long? OwnersProjectId { get ; set; }

		/// <summary>
		/// The unique identifier for the Project Photo
		/// </summary>
		[JsonProperty("photo_id")]	public  long? PhotoId { get ; set; }

		/// <summary>
		/// The inbound email address username suffix for the project.
		/// </summary>
		[JsonProperty("inbound_email")]	public  string InboundEmail { get ; set; }

		/// <summary>
		/// The Estimated Start Date of the Project Note: this field is now deprecated and will mirror the value of start_date until it is no longer supported.
		/// </summary>
		[JsonProperty("estimated_start_date")]	public  string EstimatedStartDate { get ; set; }

		/// <summary>
		/// The Estimated Completion Date of the Project. Note: this field is now deprecated and will mirror the value of completion_date until it is no longer supported.
		/// </summary>
		[JsonProperty("estimated_completion_date")]	public  string EstimatedCompletionDate { get ; set; }

		/// <summary>
		/// The Estimated Value of the project. Note: this field is now deprecated and will mirror the value of total_value until it is no longer supported.
		/// </summary>
		[JsonProperty("estimated_value")]	public  decimal? EstimatedValue { get ; set; }

		[JsonProperty("persistent_message")]	public  ProjectPersistentMessage PersistentMessage { get ; set; }

		[JsonProperty("office")]	public  ProjectOffice Office { get ; set; }

		[JsonProperty("project_bid_type")]	public  ProjectBidType ProjectBidType { get ; set; }

		[JsonProperty("project_owner_type")]	public  ProjectOwnerType ProjectOwnerType { get ; set; }

		[JsonProperty("project_region")]	public  ProjectRegion ProjectRegion { get ; set; }

		[JsonProperty("project_stage")]	public  ProjectStage ProjectStage { get ; set; }

		[JsonProperty("project_type")]	public  ProjectType ProjectType { get ; set; }

		[JsonProperty("program")]	public  ProjectProgram Program { get ; set; }

		/// <summary>
		/// An array of project departments
		/// </summary>
		[JsonProperty("departments")]	public  List<ProjectDepartment> Departments { get ; set; }

		[JsonProperty("company")]	public  ProjectCompany Company { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }
	}
}
