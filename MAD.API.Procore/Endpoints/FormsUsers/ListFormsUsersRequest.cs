using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.FormsUsers.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.FormsUsers {
	public class ListFormsUsersRequest : ProcorePaginatedRequest<ListFormsUsersRequestResult> {

		public override string Resource { get => $"/projects/{this.ProjectId}/forms/users";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
