using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.CoordinationIssueStatusTotals.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.CoordinationIssueStatusTotals {
	public class ShowCoordinationIssueCountByStatusRequest : ProcoreRequest<ShowCoordinationIssueCountByStatusRequestResult> {

		public override string Resource { get => $"/coordination_issues/status_total";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
