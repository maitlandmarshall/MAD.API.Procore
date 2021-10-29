using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.CompanyVendors.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.CompanyVendors {
	public class ShowCompanyVendorRequest : ProcoreRequest<ShowCompanyVendorRequestResult> {

		public override string Resource { get => $"/vendors/{this.Id}";}

		/// <summary>
		/// ID of the vendor
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the company.
		/// </summary>
		[RequestParameter("company_id")]	public  long CompanyId { get ; set; }

		/// <summary>
		/// The compact view provides only the id and name. The extended view provides what is shown below.
		/// The normal view is the same as the extended view but excludes children_count, legal_name, parent, bidding, project_ids, standard_cost_codes, contract_signers_name, invoice_contacts_names, default_bid_invitees_names, and country_name.
		/// The erp view is the same as the normal view but it includes origin_custom_fields.
		/// The default view is extended.
		/// </summary>
		[RequestParameter("view")]	public  string View { get ; set; }
	}
}
