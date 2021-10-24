using MAD.API.Procore.Endpoints.CompanyVendors.Models;
using MAD.API.Procore.Requests;
using System.Net.Http;
namespace MAD.API.Procore.Endpoints.CompanyVendors
{
    public class CreateCompanyVendorRequest : ProcoreRequest<CreateCompanyVendorRequestResult>
    {

        public override string Resource { get => $"/vendors"; }

        public override HttpMethod HttpMethod { get => HttpMethod.Post; }

        /// <summary>
        /// The compact view provides only the id and name. The extended view provides what is shown below.
        /// The normal view is the same as the extended view but excludes children_count, legal_name, parent, bidding, project_ids, standard_cost_codes, contract_signers_name, invoice_contacts_names, default_bid_invitees_names, and country_name.
        /// The erp view is the same as the normal view but it includes origin_custom_fields.
        /// The default view is extended.
        /// </summary>
        [RequestParameter("view")] public string View { get; set; }

        /// <summary>
        /// If true, validations are run for the corresponding Configurable Field Set.
        /// </summary>
        [RequestParameter("run_configurable_validations")] public bool RunConfigurableValidations { get; set; }
    }
}
