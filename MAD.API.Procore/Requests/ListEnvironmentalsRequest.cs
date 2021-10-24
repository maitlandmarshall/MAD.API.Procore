using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListEnvironmentalsRequest : ProcoreRequest<ListEnvironmentalsRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/incidents/environmentals"; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Incident ID. When provided, the list will be scoped to only the Environmentals for a given Incident.
        /// </summary>
        [RequestParameter("incident_id")] public long IncidentId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Environmental Type IDs
        /// </summary>
        [RequestParameter("filters[environmental_type_id]")] public string[] EnvironmentalTypeId { get; set; }

        /// <summary>
        /// Return item(s) containing search query
        /// </summary>
        [RequestParameter("filters[query]")] public string Query { get; set; }

        [RequestParameter("sort")] public string Sort { get; set; }
    }
}
