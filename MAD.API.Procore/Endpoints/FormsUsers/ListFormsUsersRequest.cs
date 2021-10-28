using MAD.API.Procore.Endpoints.FormsUsers.Models;
using System.Collections.Generic;

namespace MAD.API.Procore.Endpoints.FormsUsers
{
    public class ListFormsUsersRequest : ProcoreRequest<IEnumerable<FormsUser>>
    {

        public override string Resource { get => $"/projects/{this.ProjectId}/forms/users"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
