using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.CoordinationIssuePotentialAssignees.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.CoordinationIssuePotentialAssignees {
	public class ListCoordinationIssueAssignableUsersRequest : ProcorePaginatedRequest<IEnumerable<ListCoordinationIssueAssignableUsersRequestResult>> {

		public override string Resource { get => $"/coordination_issues/assignees";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
