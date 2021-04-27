using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.CompanyVendors.Models;
using MAD.API.Procore;
using MAD.API.Procore.Requests;
using System.Net.Http;
namespace MAD.API.Procore.Endpoints.CompanyVendors {
	public class SyncCompanyVendorsRequest : ProcoreRequest<SyncCompanyVendorsRequestResult> {

		public override string Resource { get => $"/vendors/sync";}

		public override HttpMethod HttpMethod { get => HttpMethod.Patch;}

		/// <summary>
		/// If true, validations are run for the corresponding Configurable Field Set.
		/// </summary>
		[RequestParameter("run_configurable_validations")]	public  bool RunConfigurableValidations { get ; set; }
	}
}
