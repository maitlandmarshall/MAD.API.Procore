using MAD.API.Procore.Endpoints.DailyLogs.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.DailyLogs
{
    public class FindDailyLogsRequest : ProcoreRequest<FindDailyLogsRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/daily_logs"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Vendor IDs.
        /// </summary>
        [RequestParameter("filters[vendor_id]")] public int[] VendorId { get; set; }

        /// <summary>
        /// Return item(s) with the specified Location IDs.
        /// </summary>
        [RequestParameter("filters[location_id]")] public int[] LocationId { get; set; }

        /// <summary>
        /// Returns item(s) created by the specified User IDs.
        /// </summary>
        [RequestParameter("filters[created_by_id]")] public int[] CreatedById { get; set; }

        /// <summary>
        /// The date (YYYY-MM-DD) from which to begin returning logs.
        /// Note that this field is required *unless* the `query` parameter is provided.
        /// 
        /// </summary>
        [RequestParameter("filters[start_date]")] public string StartDate { get; set; }

        /// <summary>
        /// The date (YYYY-MM-DD) from which to stop returning logs.
        /// Note that this field is required *unless* the `query` parameter is provided.
        /// 
        /// </summary>
        [RequestParameter("filters[end_date]")] public string EndDate { get; set; }

        /// <summary>
        /// A string to search Daily Logs for.
        /// 
        /// Note that using the `query` parameter overrides all other filters.
        /// 
        /// </summary>
        [RequestParameter("filters[query]")] public string Query { get; set; }

        /// <summary>
        /// Limits Daily Log results to the given Log Types. Example: `manpower_logs`.
        /// 
        /// </summary>
        [RequestParameter("filters[log_types]")] public string LogTypes { get; set; }

        /// <summary>
        /// Limits Daily Log results to those with the given status.
        /// 
        /// </summary>
        [RequestParameter("filters[status]")] public int[] Status { get; set; }

        /// <summary>
        /// The `with_related_items` view includes an additional response key, `related_items`, that includes all Related Items for the returned Daily Logs. The default view is normal.
        /// 
        /// </summary>
        [RequestParameter("view")] public string View { get; set; }
    }
}
