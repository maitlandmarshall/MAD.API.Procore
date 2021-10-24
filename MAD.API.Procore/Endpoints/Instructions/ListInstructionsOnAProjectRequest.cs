using MAD.API.Procore.Endpoints.Instructions.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Instructions
{
    public class ListInstructionsOnAProjectRequest : ProcoreRequest<IEnumerable<ListInstructionsOnAProjectRequestResult>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/instructions"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
