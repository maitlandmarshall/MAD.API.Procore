using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Companies.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Companies {
	public class ListCompaniesRequest : ProcorePaginatedRequest<ArrayOfCompany> {

		public override string Resource { get => $"/companies";}
	}
}
