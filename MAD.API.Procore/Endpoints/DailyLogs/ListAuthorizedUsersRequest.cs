using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.DailyLogs.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.DailyLogs {
	public class ListAuthorizedUsersRequest : ProcorePaginatedRequest<IEnumerable<ListAuthorizedUsersRequestResult>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/daily_logs/users";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
