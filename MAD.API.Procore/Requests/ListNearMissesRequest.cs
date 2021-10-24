using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListNearMissesRequest : ProcoreRequest<ListNearMissesRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/incidents/near_misses"; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Incident ID. When provided, the list will be scoped to only the Near Misses for a given Incident.
        /// </summary>
        [RequestParameter("incident_id")] public long IncidentId { get; set; }

        /// <summary>
        /// Return item(s) within a specific created at iso8601 datetime range
        /// </summary>
        [RequestParameter("filters[created_at]")] public string CreatedAt { get; set; }

        /// <summary>
        /// Return item(s) with the specified Affected Company IDs
        /// </summary>
        [RequestParameter("filters[affected_company_id]")] public string[] AffectedCompanyId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Affected Party IDs
        /// </summary>
        [RequestParameter("filters[affected_party_id]")] public string[] AffectedPartyId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Affected Person IDs
        /// </summary>
        [RequestParameter("filters[affected_person_id]")] public string[] AffectedPersonId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Harm Source IDs
        /// </summary>
        [RequestParameter("filters[harm_source_id]")] public string[] HarmSourceId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Work Activity IDs
        /// </summary>
        [RequestParameter("filters[work_activity_id]")] public string[] WorkActivityId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Managed Equipment IDs
        /// </summary>
        [RequestParameter("filters[managed_equipment_id]")] public long ManagedEquipmentId { get; set; }

        /// <summary>
        /// Return item(s) containing query
        /// </summary>
        [RequestParameter("filters[query]")] public string Query { get; set; }

        [RequestParameter("sort")] public string Sort { get; set; }
    }
}
