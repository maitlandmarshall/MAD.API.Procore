using MAD.API.Procore.Endpoints.DailyLogHeaders.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.DailyLogHeaders
{
    public class GetTheDailyLogHeaderViaDateOrIdRequest : ProcoreRequest<ADailyLogHeader>
    {

        public override string Resource { get => $"/projects/{ProjectId}/daily_log_headers"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// The id of the requested Daily Log Header
        /// </summary>
        [RequestParameter("id")] public long Id { get; set; }

        /// <summary>
        /// The log date for the requested Daily Log Header
        /// </summary>
        [RequestParameter("log_date")] public string LogDate { get; set; }
    }
}
