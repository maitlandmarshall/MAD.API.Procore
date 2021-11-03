using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Tasks.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Tasks {
	public class ListTasksRequest : ProcorePaginatedRequest<IEnumerable<Task>> {

		public override string Resource { get => $"/tasks";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string? UpdatedAt { get ; set; }
	}
}
