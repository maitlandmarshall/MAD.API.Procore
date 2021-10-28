using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ScheduleResources.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.ScheduleResources {
	public class ListResourcesRequest : ProcorePaginatedRequest<ListResourcesRequestResult> {

		public override string Resource { get => $"/resources";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
