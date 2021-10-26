using MAD.API.Procore.Endpoints.Drawings.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Drawings
{
    public class ListDrawingSetsRequest : ProcoreRequest<IEnumerable<DrawingSet>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/drawing_sets"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// If true, returns drawing sets that contain at least one drawing.
        /// </summary>
        [RequestParameter("filters[exclude_empty_sets]")] public bool ExcludeEmptySets { get; set; }
    }
}
