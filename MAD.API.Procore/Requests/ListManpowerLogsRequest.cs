using MAD.API.Procore.Models;
using System.Collections.Generic;
namespace MAD.API.Procore.Requests
{
    public class ListManpowerLogsRequest : ProcoreRequest<IEnumerable<ManpowerLog>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/manpower_logs"; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Date of specific logs desired in YYYY-MM-DD format
        /// </summary>
        [RequestParameter("log_date")] public string LogDate { get; set; }

        /// <summary>
        /// Start date of specific logs desired in YYYY-MM-DD format (use together with end_date)
        /// </summary>
        [RequestParameter("start_date")] public string StartDate { get; set; }

        /// <summary>
        /// End date of specific logs desired in YYYY-MM-DD format (use together with start_date)
        /// </summary>
        [RequestParameter("end_date")] public string EndDate { get; set; }

        /// <summary>
        /// Filter on status for "pending" or "approved" or "all"
        /// </summary>
        [RequestParameter("filters[status]")] public string Status { get; set; }

        /// <summary>
        /// Return item(s) created by the specified User IDs
        /// </summary>
        [RequestParameter("filters[created_by_id]")] public string[] CreatedById { get; set; }

        /// <summary>
        /// Search query
        /// </summary>
        [RequestParameter("filters[search]")] public string Search { get; set; }
    }
}
