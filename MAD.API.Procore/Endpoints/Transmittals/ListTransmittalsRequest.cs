using MAD.API.Procore.Endpoints.Transmittals.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Transmittals
{
    public class ListTransmittalsRequest : ProcoreRequest<IEnumerable<ListTransmittalsRequestResult>>
    {

        public override string Resource { get => $"/transmittals"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Search Query
        /// </summary>
        [RequestParameter("filters[query]")] public string Query { get; set; }
    }
}
