using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ProjectRegions.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.ProjectRegions {
	public class ListProjectRegionsRequest : ProcorePaginatedRequest<IEnumerable<ProjectRegion>> {

		public override string Resource { get => $"/companies/{this.CompanyId}/project_regions";}

		/// <summary>
		/// Unique identifier for the company.
		/// </summary>
		[RequestParameter("company_id")]	public  long CompanyId { get ; set; }
	}
}
