using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ChecklistTemplates.Models;
using MAD.API.Procore;

namespace MAD.API.Procore.Endpoints.ChecklistTemplates {
	public class ShowChecklistTemplateRequest : ProcoreRequest<ChecklistTemplate> {

		public override string Resource { get => $"/checklist/list_templates/{this.Id}";}

		/// <summary>
		/// Checklist Template ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
