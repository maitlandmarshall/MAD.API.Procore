using MAD.API.Procore.Endpoints.Observations.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;

namespace MAD.API.Procore.Endpoints.Observations
{
    public class ListObservationItemsRequest : ProcoreRequest<IEnumerable<ObservationItem>>
    {
        public override string Resource { get => $"/projects/{ProjectId}/observations/items"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Observation Type ID.
        /// </summary>
        [RequestParameter("filters[type_id]")] public int[] TypeId { get; set; }

        /// <summary>
        /// Array of Trade IDs. Returns item(s) with the specified Trade IDs.
        /// </summary>
        [RequestParameter("filters[trade_ids]")] public int[] TradeIds { get; set; }

        /// <summary>
        /// Return item(s) assigned to the specified User ID.
        /// </summary>
        [RequestParameter("filters[assignee_id]")] public int[] AssigneeId { get; set; }

        /// <summary>
        /// Return item(s) with the specified status values. The mapping is as follows:
        /// ```
        ///   0: Initiated
        ///   1: Ready For reviewed
        ///   2: Not Accepted
        ///   3: Closed
        /// ```
        /// </summary>
        [RequestParameter("filters[status]")] public int[] Status { get; set; }

        /// <summary>
        /// Return item(s) with the specified priorities.
        /// 
        /// </summary>
        [RequestParameter("filters[priority]")] public int[] Priority { get; set; }

        /// <summary>
        /// Return item(s) with the specified Location IDs.
        /// </summary>
        [RequestParameter("filters[location_id]")] public int[] LocationId { get; set; }

        /// <summary>
        /// Returns item(s) created by the specified User IDs.
        /// </summary>
        [RequestParameter("filters[created_by_id]")] public int[] CreatedById { get; set; }

        /// <summary>
        /// Array of Vendor IDs. Returns item(s) where the assignee is associated to the specified Vendor ID.
        /// </summary>
        [RequestParameter("filters[assignee_company_id]")] public int[] AssigneeCompanyId { get; set; }

        /// <summary>
        /// Return item(s) last updated within the specified ISO 8601 datetime range.
        /// </summary>
        [RequestParameter("filters[updated_at]")] public string UpdatedAt { get; set; }
    }
}
