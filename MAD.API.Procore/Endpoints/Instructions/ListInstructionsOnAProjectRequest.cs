using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Instructions.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Instructions {
	public class ListInstructionsOnAProjectRequest : ProcorePaginatedRequest<IEnumerable<ListInstructionsOnAProjectRequestResult>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/instructions";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
