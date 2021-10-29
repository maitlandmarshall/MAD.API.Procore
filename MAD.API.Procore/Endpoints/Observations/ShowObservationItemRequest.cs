using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Observations.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Observations {
	public class ShowObservationItemRequest : ProcoreRequest<ObservationItem> {

		public override string Resource { get => $"/observations/items/{this.Id}";}

		/// <summary>
		/// Observation Item ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
