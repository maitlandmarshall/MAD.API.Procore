using MAD.API.Procore.Endpoints.Instructions.Models;

namespace MAD.API.Procore.Endpoints.Instructions
{
    public class ShowInstructionRequest : ProcoreRequest<ShowInstructionRequestResult>
    {

        public override string Resource { get => $"/projects/{ProjectId}/instructions/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Instruction ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
