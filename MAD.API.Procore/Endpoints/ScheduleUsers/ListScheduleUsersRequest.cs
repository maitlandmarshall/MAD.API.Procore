using MAD.API.Procore.Endpoints.ScheduleUsers.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ScheduleUsers
{
    public class ListScheduleUsersRequest : ProcoreRequest<IEnumerable<ListScheduleUsersRequestResult>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/schedule/users"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
