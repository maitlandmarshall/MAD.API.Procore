using MAD.API.Procore.Endpoints.PunchItemTypes.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.PunchItemTypes
{
    public class ShowPunchItemTypeRequest : ProcoreRequest<PunchItemType>
    {

        public override string Resource { get => $"/punch_item_types/{Id}"; }

        /// <summary>
        /// ID of the Punch Item Type
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
