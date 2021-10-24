using MAD.API.Procore.Models;
using System.Collections.Generic;
namespace MAD.API.Procore.Requests
{
    public class ListActionsRequest : ProcoreRequest<IEnumerable<ListActionsRequestResult>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/incidents/actions"; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Incident ID. When provided, the list will be scoped to only the Actions for a given Incident.
        /// </summary>
        [RequestParameter("incident_id")] public long IncidentId { get; set; }

        /// <summary>
        /// Return item(s) within a specific created at iso8601 datetime range
        /// </summary>
        [RequestParameter("filters[created_at]")] public string CreatedAt { get; set; }

        /// <summary>
        /// Return item(s) within a specific updated at iso8601 datetime range
        /// </summary>
        [RequestParameter("filters[updated_at]")] public string UpdatedAt { get; set; }

        /// <summary>
        /// Return item(s) containing query
        /// </summary>
        [RequestParameter("filters[query]")] public string Query { get; set; }

        [RequestParameter("sort")] public string Sort { get; set; }
    }
}
