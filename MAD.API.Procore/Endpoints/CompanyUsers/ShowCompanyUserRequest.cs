using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.CompanyUsers.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.CompanyUsers {
	public class ShowCompanyUserRequest : ProcoreRequest<User> {

		public override string Resource { get => $"/companies/{this.CompanyId}/users/{this.Id}";}

		/// <summary>
		/// Unique identifier for the company.
		/// </summary>
		[RequestParameter("company_id")]	public  long CompanyId { get ; set; }

		/// <summary>
		/// ID of the user
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }
	}
}
