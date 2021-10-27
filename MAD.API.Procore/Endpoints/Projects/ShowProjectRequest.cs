using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Projects.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Projects {
	public class ShowProjectRequest : ProcoreRequest<Project> {

		public override string Resource { get => $"/projects/{this.Id}";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the company.
		/// </summary>
		[RequestParameter("company_id")]	public  long CompanyId { get ; set; }
	}
}
