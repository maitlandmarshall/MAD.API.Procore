using MAD.API.Procore.Endpoints.SpecificationSets.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.SpecificationSets
{
    public class ShowSpecificationSetRequest : ProcoreRequest<ShowSpecificationSetRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/specification_sets/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// ID of the specification section to show
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
