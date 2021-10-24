using MAD.API.Procore.Endpoints.CoordinationIssues.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.CoordinationIssues
{
    public class ShowCoordinationIssueRequest : ProcoreRequest<CoordinationIssue>
    {

        public override string Resource { get => $"/coordination_issues/{Id}"; }

        /// <summary>
        /// Coordination Issue ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// The compact view contains only ids.
        /// The normal view is a subset of the response shown below, and does not include attachments, viewpoints, linked items and updated_by
        /// The extended view contains the response shown below.
        /// The default view is normal.
        /// </summary>
        [RequestParameter("view")] public string View { get; set; }

        /// <summary>
        /// Specify viewpoint data format. This parameter functions only when the query parameter view is 'extended'
        /// The default format returns the viewpoint content as saved.
        /// The procore format returns the viewpoint content converted to Procore format. If a valid conversion is not possible, empty viewpoint is returned.
        /// </summary>
        [RequestParameter("viewpoint_format")] public string ViewpointFormat { get; set; }
    }
}
