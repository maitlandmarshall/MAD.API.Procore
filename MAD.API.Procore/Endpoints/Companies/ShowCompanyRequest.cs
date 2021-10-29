using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Companies.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Companies {
	public class ShowCompanyRequest : ProcoreRequest<Company> {

		public override string Resource { get => $"/companies/{this.Id}";}

		/// <summary>
		/// id of the company
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the company.
		/// </summary>
		[RequestParameter("company_id")]	public  long CompanyId { get ; set; }
	}
}
