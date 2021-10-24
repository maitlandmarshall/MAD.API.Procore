using MAD.API.Procore.Endpoints.Meetings.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Meetings
{
    public class ListMeetingsRequest : ProcoreRequest<IEnumerable<Meeting>>
    {

        public override string Resource { get => $"/meetings"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// The data set that should be returned from the serializer.
        /// The normal view includes default fields.
        /// The extended view includes the default fields plus Meeting Template fields.
        /// Default view is normal.
        /// </summary>
        [RequestParameter("serializer_view")] public string SerializerView { get; set; }
    }
}
