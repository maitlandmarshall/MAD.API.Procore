using MAD.API.Procore.Endpoints.CompanyVendors.Models;

using System.Net.Http;
namespace MAD.API.Procore.Endpoints.CompanyVendors
{
    public class SyncCompanyVendorsRequest : ProcoreRequest<SyncCompanyVendorsRequestResult>
    {

        public override string Resource { get => $"/vendors/sync"; }

        public override HttpMethod HttpMethod { get => HttpMethod.Patch; }

        /// <summary>
        /// If true, validations are run for the corresponding Configurable Field Set.
        /// </summary>
        [RequestParameter("run_configurable_validations")] public bool RunConfigurableValidations { get; set; }
    }
}
