using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListResponsesRequest : ProcoreRequest<ArrayOfResponses> {
		public override string Resource { get => $"/vapid/companies/{this.CompanyId}/checklist/responses"; }

		/// <summary>
		/// Company ID
		/// </summary>
		public long CompanyId { get; set; }


		/// <summary>
		/// Return item(s) with the specified Corresponding Statuses
		/// </summary>
		[RequestParameter("filters[corresponding_status]")]
		public string[]? CorrespondingStatus { get; set; }


		/// <summary>
		/// 
		/// </summary>
		[RequestParameter("sort")]
		public string? Sort { get; set; }

	}
}
