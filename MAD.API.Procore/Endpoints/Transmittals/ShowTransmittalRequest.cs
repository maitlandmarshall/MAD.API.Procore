using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Transmittals.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Transmittals {
	public class ShowTransmittalRequest : ProcoreRequest<ShowTransmittalRequestResult> {

		public override string Resource { get => $"/transmittals/{this.Id}";}

		/// <summary>
		/// Transmittal ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
