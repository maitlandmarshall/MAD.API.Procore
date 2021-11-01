using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ManpowerLogs.Models;
using MAD.API.Procore;
using System.Net.Http;
namespace MAD.API.Procore.Endpoints.ManpowerLogs {
	public class CreateManpowerLogRequest : ProcoreRequest<CreateManpowerLogRequestResult> {

		public override string Resource { get => $"/projects/{this.ProjectId}/manpower_logs";}

		public override HttpMethod HttpMethod { get => HttpMethod.Post;}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// If true, validations are run for the corresponding Configurable Field Set.
		/// </summary>
		[RequestParameter("run_configurable_validations")]	public  bool? RunConfigurableValidations { get ; set; }
	}
}
