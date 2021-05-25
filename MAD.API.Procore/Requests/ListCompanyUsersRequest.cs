using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListCompanyUsersRequest : ProcoreRequest<ArrayOfCompanyUser> {

		public override string Resource { get => $"/companies/{this.CompanyId}/users";}

		/// <summary>
		/// Company ID
		/// </summary>
		[RequestParameter("company_id")]	public  long? CompanyId { get ; set; }

		/// <summary>
		/// Return item(s) with specified active status
		/// </summary>
		[RequestParameter("filters[active]")]	public  bool Active { get ; set; }

		/// <summary>
		/// Return item(s) within a specific created at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string CreatedAt { get ; set; }

		/// <summary>
		/// Return item(s) within a specific updated at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string UpdatedAt { get ; set; }

		/// <summary>
		/// Return item(s) with the specified Vendor IDs.
		/// </summary>
		[RequestParameter("filters[vendor_id]")]	public  string[] VendorId { get ; set; }

		/// <summary>
		/// Return an item with a specific origin ID
		/// </summary>
		[RequestParameter("filters[origin_id]")]	public  string OriginId { get ; set; }

		/// <summary>
		/// Returns users whose vendor record is associated with the specified trade id(s).
		/// </summary>
		[RequestParameter("filters[trade_id][]")]	public  string[] TradeId { get ; set; }

		/// <summary>
		/// Return users where the search string matches the user's first name, last name, email address, keywords, job title, or company name
		/// </summary>
		[RequestParameter("filters[search]")]	public  string Search { get ; set; }

		/// <summary>
		/// Return items with the specified sort.
		/// </summary>
		[RequestParameter("sort")]	public  string Sort { get ; set; }
	}
}
