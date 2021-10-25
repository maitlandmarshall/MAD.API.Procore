using MAD.API.Procore.Endpoints.SpecificationSections.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.SpecificationSections
{
    public class ListSpecificationSectionsRequest : ProcoreRequest<IEnumerable<SpecificationSection>>
    {

        public override string Resource { get => $"/specification_sections"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Return item(s) with the specified IDs.
        /// </summary>
        [RequestParameter("filters[id]")] public int[] Id { get; set; }
    }
}
