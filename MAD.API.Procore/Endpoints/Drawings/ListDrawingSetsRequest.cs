using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Drawings.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Drawings {
	public class ListDrawingSetsRequest : ProcorePaginatedRequest<IEnumerable<DrawingSet>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/drawing_sets";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// If true, returns drawing sets that contain at least one drawing.
		/// </summary>
		[RequestParameter("filters[exclude_empty_sets]")]	public  bool? ExcludeEmptySets { get ; set; }
	}
}
