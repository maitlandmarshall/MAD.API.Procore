using MAD.API.Procore.Models;
using System.Collections.Generic;
namespace MAD.API.Procore.Requests
{
    public class ListWitnessStatementsRequest : ProcoreRequest<IEnumerable<ListWitnessStatementsRequestResult>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/incidents/witness_statements"; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Incident ID. When provided, the list will be scoped to only the Witness Statements for a given Incident.
        /// </summary>
        [RequestParameter("incident_id")] public long IncidentId { get; set; }

        /// <summary>
        /// Return item(s) within a specific created at iso8601 datetime range
        /// </summary>
        [RequestParameter("filters[created_at]")] public string CreatedAt { get; set; }

        /// <summary>
        /// Return item(s) within a specific date received date range. This assumes the dates provided are in the project timezone.
        /// </summary>
        [RequestParameter("filters[date_received]")] public string DateReceived { get; set; }

        /// <summary>
        /// Return item(s) with the specified Witness (Party) IDs
        /// </summary>
        [RequestParameter("filters[witness_id]")] public string[] WitnessId { get; set; }

        /// <summary>
        /// Return item(s) containing query
        /// </summary>
        [RequestParameter("filters[query]")] public string Query { get; set; }

        [RequestParameter("sort")] public string Sort { get; set; }
    }
}
