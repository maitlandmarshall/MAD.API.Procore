using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.PunchItemTypes.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.PunchItemTypes {
	public class ListPunchItemTypesRequest : ProcorePaginatedRequest<IEnumerable<PunchItemType>> {

		public override string Resource { get => $"/punch_item_types";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
