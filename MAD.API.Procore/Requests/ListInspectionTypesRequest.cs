using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListInspectionTypesRequest : ProcoreRequest<ArrayOfInspectionTypes> {
		public override string Resource { get => $"/vapid/companies/{this.CompanyId}/inspection_types"; }

		/// <summary>
		/// Company ID
		/// </summary>
		public long CompanyId { get; set; }

	}
}
