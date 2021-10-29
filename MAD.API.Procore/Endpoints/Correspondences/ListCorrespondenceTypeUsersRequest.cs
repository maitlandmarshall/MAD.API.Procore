using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Correspondences.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Correspondences {
	public class ListCorrespondenceTypeUsersRequest : ProcorePaginatedRequest<IEnumerable<CorrespondenceTypeUser>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/correspondence_types/users";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
