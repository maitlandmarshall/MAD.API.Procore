using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Transmittals.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Transmittals {
	public class ListTransmittalsRequest : ProcorePaginatedRequest<IEnumerable<ListTransmittalsRequestResult>> {

		public override string Resource { get => $"/transmittals";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Search Query
		/// </summary>
		[RequestParameter("filters[query]")]	public  string Query { get ; set; }
	}
}
