using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ScheduleUsers.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.ScheduleUsers {
	public class ListScheduleUsersRequest : ProcorePaginatedRequest<IEnumerable<ListScheduleUsersRequestResult>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/schedule/users";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
