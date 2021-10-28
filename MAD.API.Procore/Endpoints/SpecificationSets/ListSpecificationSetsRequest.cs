using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.SpecificationSets.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.SpecificationSets {
	public class ListSpecificationSetsRequest : ProcorePaginatedRequest<IEnumerable<ListSpecificationSetsRequestResult>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/specification_sets";}

		/// <summary>
		/// The ID of the project for the new set
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
