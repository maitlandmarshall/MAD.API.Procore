using MAD.API.Procore.Endpoints.SpecificationSets.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.SpecificationSets
{
    public class ListSpecificationSetsRequest : ProcoreRequest<IEnumerable<SpecificationSet>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/specification_sets"; }

        /// <summary>
        /// The ID of the project for the new set
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
