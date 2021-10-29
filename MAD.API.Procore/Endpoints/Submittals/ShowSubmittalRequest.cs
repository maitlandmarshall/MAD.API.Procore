using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Submittals.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Submittals {
	public class ShowSubmittalRequest : ProcoreRequest<Submittal> {

		public override string Resource { get => $"/projects/{this.ProjectId}/submittals/{this.Id}";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Submittal ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }
	}
}
