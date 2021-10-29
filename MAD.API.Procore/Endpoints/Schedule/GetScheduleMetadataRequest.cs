using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Schedule.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Schedule {
	public class GetScheduleMetadataRequest : ProcoreRequest<GetScheduleMetadataRequestResult> {

		public override string Resource { get => $"/projects/{this.ProjectId}/schedule";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
