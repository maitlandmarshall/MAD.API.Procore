using MAD.API.Procore.Endpoints.CompanyVendors.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CompanyVendors
{
    public class ListCompanyVendorsRequest : ProcoreRequest<IEnumerable<CompanyVendor>>
    {

        public override string Resource { get => $"/vendors"; }

        /// <summary>
        /// The compact view provides only the id and name. The extended view provides what is shown below.
        /// The normal view is the same as the extended view but excludes children_count, legal_name, parent, bidding, project_ids, standard_cost_codes, contract_signers_name, invoice_contacts_names, default_bid_invitees_names, and country_name.
        /// The erp view is the same as the normal view but it includes origin_custom_fields.
        /// The default view is extended.
        /// </summary>
        [RequestParameter("view")] public string View { get; set; }

        /// <summary>
        /// Unique identifier for the company.
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }

        /// <summary>
        /// Origin ID. Returns item(s) with the specified Origin ID.
        /// </summary>
        [RequestParameter("filters[origin_id]")] public string OriginId { get; set; }

        /// <summary>
        /// Return vendors where the search string matches the vendor name, keywords, origin_code, or ABN/EIN number
        /// </summary>
        [RequestParameter("filters[search]")] public string Search { get; set; }

        /// <summary>
        /// Return items within a specific created at ISO8601 datetime range
        /// </summary>
        [RequestParameter("filters[created_at]")] public string CreatedAt { get; set; }

        /// <summary>
        /// Return items within a specific updated at ISO8601 datetime range
        /// </summary>
        [RequestParameter("filters[updated_at]")] public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns vendors associated with the specified standard cost code id(s)
        /// </summary>
        [RequestParameter("filters[standard_cost_code_id][]")] public string[] StandardCostCodeId { get; set; }

        /// <summary>
        /// Returns vendors associated with the specified trade id(s)
        /// </summary>
        [RequestParameter("filters[trade_id][]")] public string[] TradeId { get; set; }

        /// <summary>
        /// Returns vendors with the specified id(s)
        /// </summary>
        [RequestParameter("filters[id][]")] public string[] Id { get; set; }

        /// <summary>
        /// Returns vendors with the specified parent id(s)
        /// </summary>
        [RequestParameter("filters[parent_id][]")] public string[] ParentId { get; set; }

        /// <summary>
        /// Return items with the specified sort
        /// </summary>
        [RequestParameter("sort")] public string Sort { get; set; }
    }
}
