using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ProjectRegions.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.ProjectRegions {
	public class ShowProjectRegionRequest : ProcoreRequest<ProjectRegion> {

		public override string Resource { get => $"/companies/{this.CompanyId}/project_regions/{this.Id}";}

		/// <summary>
		/// Unique identifier for the company.
		/// </summary>
		[RequestParameter("company_id")]	public  long CompanyId { get ; set; }

		/// <summary>
		/// ID of the Project Region
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }
	}
}
