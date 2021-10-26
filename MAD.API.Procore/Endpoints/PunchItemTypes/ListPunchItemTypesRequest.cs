using MAD.API.Procore.Endpoints.PunchItemTypes.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.PunchItemTypes
{
    public class ListPunchItemTypesRequest : ProcoreRequest<IEnumerable<PunchItemType>>
    {

        public override string Resource { get => $"/punch_item_types"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
