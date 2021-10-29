using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Checklists.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Checklists {
	public class ShowChecklistInspectionRequest : ProcoreRequest<Checklist> {

		public override string Resource { get => $"/projects/{this.ProjectId}/checklist/lists/{this.Id}";}

		/// <summary>
		/// Checklist ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
