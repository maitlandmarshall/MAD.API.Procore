using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ProjectRoles.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.ProjectRoles {
	public class ListProjectRolesRequest : ProcorePaginatedRequest<IEnumerable<ProjectRole>> {

		public override string Resource { get => $"/rest/v1.0/project_roles";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Return item(s) created within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string? CreatedAt { get ; set; }
	}
}
