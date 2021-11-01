using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Transmittals.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Transmittals {
	public class ListTransmittalItemsRequest : ProcorePaginatedRequest<IEnumerable<ListTransmittalItemsRequestResult>> {

		public override string Resource { get => $"/transmittals/{this.TransmittalId}/items";}

		/// <summary>
		/// Transmittal ID
		/// </summary>
		[RequestParameter("transmittal_id")]	public  long TransmittalId { get ; set; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
