using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.BIMModels.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.BIMModels {
	public class ShowBIMModelRequest : ProcoreRequest<BIMModel> {

		public override string Resource { get => $"/bim_models/{this.Id}";}

		/// <summary>
		/// BIM Model ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// The compact view contains only ids.
		/// The extended view contains the response shown below.
		/// The normal view contains 'current_revision_id' instead of an embedded object 'current_revision'
		/// The default view is normal.
		/// </summary>
		[RequestParameter("view")]	public  string View { get ; set; }
	}
}
