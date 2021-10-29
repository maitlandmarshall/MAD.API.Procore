using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.RFIs.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.RFIs {
	public class ShowRFIRequest : ProcoreRequest<ShowRFIRequestResult> {

		public override string Resource { get => $"/rfis/{this.Id}";}

		/// <summary>
		/// RFI ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
