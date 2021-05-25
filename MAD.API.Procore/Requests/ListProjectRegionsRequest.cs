using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListProjectRegionsRequest : ProcoreRequest<ArrayOfProjectRegion> {

		public override string Resource { get => $"/companies/{this.CompanyId}/project_regions";}

		/// <summary>
		/// Company ID
		/// </summary>
		[RequestParameter("company_id")]	public  long? CompanyId { get ; set; }
	}
}
