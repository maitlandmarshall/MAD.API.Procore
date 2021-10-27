using MAD.API.Procore.Endpoints.DailyLogs.Models;

using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.DailyLogs
{
    public class ListAuthorizedUsersRequest : ProcoreRequest<IEnumerable<ListAuthorizedUsersRequestResult>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/daily_logs/users"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
