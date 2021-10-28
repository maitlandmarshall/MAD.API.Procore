using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ChecklistTemplates.Models;
using MAD.API.Procore;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.ChecklistTemplates {
	public class ListChecklistTemplatesRequest : ProcoreRequest<ArrayOfChecklistTemplate> {

		public override string Resource { get => $"/checklist/list_templates";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
