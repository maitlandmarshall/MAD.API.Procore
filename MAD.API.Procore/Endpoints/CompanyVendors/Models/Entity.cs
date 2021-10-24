using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CompanyVendors.Models
{
    public class Entity
    {

        /// <summary>
        /// Array of Project IDs
        /// </summary>
        [JsonProperty("project_ids")] public List<long> ProjectIds { get; set; }

        [JsonProperty("standard_cost_codes")] public List<StandardCostCode> StandardCostCodes { get; set; }

        /// <summary>
        /// Count of vendors whose parent_id is this vendor's unique identifier
        /// </summary>
        [JsonProperty("children_count")] public int? ChildrenCount { get; set; }

        /// <summary>
        /// Name of the parent, if one exists. Otherwise same as name.
        /// </summary>
        [JsonProperty("legal_name")] public string LegalName { get; set; }

        [JsonProperty("parent")] public Parent Parent { get; set; }

        /// <summary>
        /// Trades
        /// </summary>
        [JsonProperty("trades")] public List<Trade> Trades { get; set; }

        /// <summary>
        /// Bidding distribution list
        /// </summary>
        [JsonProperty("bidding_distribution")] public List<BiddingDistribution> BiddingDistribution { get; set; }

        /// <summary>
        /// Bidding status
        /// </summary>
        [JsonProperty("bidding")] public Bidding Bidding { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Abbreviated name
        /// </summary>
        [JsonProperty("abbreviated_name")] public string AbbreviatedName { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")] public string Address { get; set; }

        /// <summary>
        /// Authorized bidder status
        /// </summary>
        [JsonProperty("authorized_bidder")] public bool AuthorizedBidder { get; set; }

        /// <summary>
        /// Business phone
        /// </summary>
        [JsonProperty("business_phone")] public string BusinessPhone { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("city")] public string City { get; set; }

        /// <summary>
        /// Count of active Contacts associated with the vendor record.
        /// </summary>
        [JsonProperty("contact_count")] public int? ContactCount { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        [JsonProperty("company")] public string Company { get; set; }

        /// <summary>
        /// Country code (ISO-3166 Alpha-2 format)
        /// </summary>
        [JsonProperty("country_code")] public string CountryCode { get; set; }

        /// <summary>
        /// Created at
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [JsonProperty("email_address")] public string EmailAddress { get; set; }

        /// <summary>
        /// Fax number
        /// </summary>
        [JsonProperty("fax_number")] public string FaxNumber { get; set; }

        /// <summary>
        /// Active status
        /// </summary>
        [JsonProperty("is_active")] public bool IsActive { get; set; }

        /// <summary>
        /// Labor union
        /// </summary>
        [JsonProperty("labor_union")] public string LaborUnion { get; set; }

        /// <summary>
        /// License number
        /// </summary>
        [JsonProperty("license_number")] public string LicenseNumber { get; set; }

        /// <summary>
        /// Logo url
        /// </summary>
        [JsonProperty("logo")] public string Logo { get; set; }

        /// <summary>
        /// Mobile phone
        /// </summary>
        [JsonProperty("mobile_phone")] public string MobilePhone { get; set; }

        /// <summary>
        /// Non-union prevailing wage status
        /// </summary>
        [JsonProperty("non_union_prevailing_wage")] public bool NonUnionPrevailingWage { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        [JsonProperty("notes")] public string Notes { get; set; }

        /// <summary>
        /// Origin data
        /// </summary>
        [JsonProperty("origin_data")] public string OriginData { get; set; }

        /// <summary>
        /// Origin unique identifiers
        /// </summary>
        [JsonProperty("origin_id")] public string OriginId { get; set; }

        /// <summary>
        /// Origin Code
        /// </summary>
        [JsonProperty("origin_code")] public string OriginCode { get; set; }

        /// <summary>
        /// Prequalified status
        /// </summary>
        [JsonProperty("prequalified")] public bool Prequalified { get; set; }

        /// <summary>
        /// State code (ISO-3166 Alpha-2 format)
        /// </summary>
        [JsonProperty("state_code")] public string StateCode { get; set; }

        /// <summary>
        /// Synced to ERP
        /// </summary>
        [JsonProperty("synced_to_erp")] public bool SyncedToErp { get; set; }

        /// <summary>
        /// Vendor's Trade Name, also known as Doing Business As (DBA).
        /// </summary>
        [JsonProperty("trade_name")] public string TradeName { get; set; }

        /// <summary>
        /// Union member status
        /// </summary>
        [JsonProperty("union_member")] public bool UnionMember { get; set; }

        /// <summary>
        /// Updated at
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Website url
        /// </summary>
        [JsonProperty("website")] public string Website { get; set; }

        /// <summary>
        /// Zip code
        /// </summary>
        [JsonProperty("zip")] public string Zip { get; set; }

        /// <summary>
        /// business register
        /// </summary>
        [JsonProperty("business_register")] public BusinessRegister BusinessRegister { get; set; }

        [JsonProperty("vendor_group")] public VendorGroup VendorGroup { get; set; }

        /// <summary>
        /// Primary contact
        /// </summary>
        [JsonProperty("primary_contact")] public PrimaryContact PrimaryContact { get; set; }

        /// <summary>
        /// Attachments
        /// </summary>
        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }
    }
}
