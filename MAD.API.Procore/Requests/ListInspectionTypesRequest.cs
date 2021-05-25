using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListInspectionTypesRequest : ProcoreRequest<ArrayOfInspectionTypes> {

		public override string Resource { get => $"/companies/{this.CompanyId}/inspection_types";}

		/// <summary>
		/// Company ID
		/// </summary>
		[RequestParameter("company_id")]	public  long? CompanyId { get ; set; }
	}
}
