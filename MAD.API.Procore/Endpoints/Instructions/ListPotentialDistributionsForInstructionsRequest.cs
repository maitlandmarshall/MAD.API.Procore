using MAD.API.Procore.Endpoints.Instructions.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.Instructions
{
    public class ListPotentialDistributionsForInstructionsRequest : ProcoreRequest<ListOfPotentialDistribution>
    {

        public override string Resource { get => $"/projects/{ProjectId}/instructions/potential_distribution"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Minumim user access level
        /// 1 => "None"
        /// 2 => "Read Only"
        /// 3 => "Standard"
        /// 4 => "Admin"
        /// </summary>
        [RequestParameter("min_ual")] public string? MinUal { get; set; }
    }
}
