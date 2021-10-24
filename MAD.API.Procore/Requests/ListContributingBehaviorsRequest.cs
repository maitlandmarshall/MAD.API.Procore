using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListContributingBehaviorsRequest : ProcoreRequest<ArrayOfContributingBehaviors>
    {

        public override string Resource { get => $"/companies/{CompanyId}/contributing_behaviors"; }

        /// <summary>
        /// Company ID
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }

        /// <summary>
        /// Return item(s) with specified active status
        /// </summary>
        [RequestParameter("filters[active]")] public bool Active { get; set; }

        /// <summary>
        /// Return item(s) with the specified IDs
        /// </summary>
        [RequestParameter("filters[id]")] public string[] Id { get; set; }

        /// <summary>
        /// Return item(s) within a specific updated at iso8601 datetime range
        /// </summary>
        [RequestParameter("filters[updated_at]")] public string UpdatedAt { get; set; }

        /// <summary>
        /// Both active and inactive Contributing Behaviors
        /// </summary>
        [RequestParameter("all")] public bool All { get; set; }
    }
}
