using MAD.API.Procore.Endpoints.PunchItems.Models;

using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.PunchItems
{
    public class ListPunchItemsRequest : ProcoreRequest<IEnumerable<PunchItem>>
    {

        public override string Resource { get => $"/punch_items"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Punch Item Status - 'open' or 'closed'.
        /// </summary>
        [RequestParameter("filters[status]")] public string Status { get; set; }

        /// <summary>
        /// Return item(s) with the specified Punch Item Priority -  'low', 'medium', 'high'
        /// </summary>
        [RequestParameter("filters[priority]")] public string Priority { get; set; }

        /// <summary>
        /// Return item(s) with the specified Punch Item Type ID.
        /// </summary>
        [RequestParameter("filters[punch_item_type_id]")] public long PunchItemTypeId { get; set; }

        /// <summary>
        /// Location ID. Returns item(s) with the specified Location ID or a range of Location IDs.
        /// </summary>
        [RequestParameter("filters[location_id]")] public int[] LocationId { get; set; }

        /// <summary>
        /// Use together with `filters[location_id]`
        /// 
        /// </summary>
        [RequestParameter("filters[include_sublocations]")] public bool IncludeSublocations { get; set; }

        /// <summary>
        /// User ID. Returns item(s) where the specified User ID is an approver.
        /// </summary>
        [RequestParameter("filters[approver_login_information_id]")] public long ApproverLoginInformationId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Vendor ID.
        /// </summary>
        [RequestParameter("filters[vendor_id]")] public long VendorId { get; set; }

        /// <summary>
        /// If true, returns item(s) with the specified assignee response approved status.
        /// </summary>
        [RequestParameter("filters[assignee_response]")] public bool AssigneeResponse { get; set; }

        /// <summary>
        /// Trade ID
        /// </summary>
        [RequestParameter("filters[trade_id]")] public long TradeId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Punch Item ID.
        /// </summary>
        [RequestParameter("filters[id]")] public int[] Id { get; set; }

        /// <summary>
        /// Return item(s) containing search query
        /// </summary>
        [RequestParameter("filters[query]")] public string Query { get; set; }

        /// <summary>
        /// Return item(s) last updated within the specified ISO 8601 datetime range.
        /// </summary>
        [RequestParameter("filters[updated_at]")] public string UpdatedAt { get; set; }
    }
}
