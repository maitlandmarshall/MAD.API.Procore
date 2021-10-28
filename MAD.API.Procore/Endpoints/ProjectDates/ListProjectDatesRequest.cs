using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ProjectDates.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.ProjectDates {
	public class ListProjectDatesRequest : ProcoreRequest<ListProjectDatesRequestResult> {

		public override string Resource { get => $"/projects/{this.ProjectId}/project_dates";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
