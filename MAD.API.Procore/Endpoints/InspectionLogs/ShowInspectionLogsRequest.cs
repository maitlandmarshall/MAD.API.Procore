using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.InspectionLogs.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.InspectionLogs {
	public class ShowInspectionLogsRequest : ProcoreRequest<InspectionLog> {

		public override string Resource { get => $"/projects/{this.ProjectId}/inspection_logs/{this.Id}";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Inspection Log ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }
	}
}
