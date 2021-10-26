using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListBodyPartsRequest : ProcoreRequest<ArrayOfBodyPart>
    {

        public override string Resource { get => $"/companies/{CompanyId}/incidents/body_parts"; }

        /// <summary>
        /// Company ID
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }

        /// <summary>
        /// Return item(s) with specified selectable status
        /// </summary>
        [RequestParameter("filters[selectable]")] public bool Selectable { get; set; }

        /// <summary>
        /// Return item(s) with the specified IDs
        /// </summary>
        [RequestParameter("filters[id]")] public string[] Id { get; set; }

        /// <summary>
        /// Return item(s) within a specific updated at iso8601 datetime range
        /// </summary>
        [RequestParameter("filters[updated_at]")] public string UpdatedAt { get; set; }

        /// <summary>
        /// Body Parts
        /// </summary>
        [RequestParameter("sort")] public string Sort { get; set; }
    }
}
