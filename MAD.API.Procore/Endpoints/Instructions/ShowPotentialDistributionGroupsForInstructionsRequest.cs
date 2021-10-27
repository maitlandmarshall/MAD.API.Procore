using MAD.API.Procore.Endpoints.Instructions.Models;

using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Instructions
{
    public class ShowPotentialDistributionGroupsForInstructionsRequest : ProcoreRequest<IEnumerable<DistributionGroup>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/instructions/potential_distribution_groups"; }

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
        [RequestParameter("min_ual")] public string MinUal { get; set; }

        /// <summary>
        /// If true return all active company logins (not only valid)
        /// </summary>
        [RequestParameter("with_quick_add")] public bool WithQuickAdd { get; set; }
    }
}
