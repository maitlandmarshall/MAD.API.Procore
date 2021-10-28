using MAD.API.Procore.Endpoints.DailyLogs.Models;

namespace MAD.API.Procore.Endpoints.DailyLogs
{
    public class GetTotalWorkersAndManHoursRequest : ProcoreRequest<TotalWorkersAndManHours>
    {

        public override string Resource { get => $"/projects/{ProjectId}/daily_log_totals"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Type of logs desired
        /// </summary>
        [RequestParameter("log_type")] public string LogType { get; set; }

        /// <summary>
        /// Start date of specific logs desired in YYYY-MM-DD format (use together with end_date)
        /// </summary>
        [RequestParameter("start_date")] public string StartDate { get; set; }

        /// <summary>
        /// End date of specific logs desired in YYYY-MM-DD format (use together with start_date)
        /// </summary>
        [RequestParameter("end_date")] public string EndDate { get; set; }

        /// <summary>
        /// Returns item(s) created by the specified User IDs.
        /// </summary>
        [RequestParameter("filters[created_by_id]")] public int[] CreatedById { get; set; }
    }
}
