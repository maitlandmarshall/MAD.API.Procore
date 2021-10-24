using MAD.API.Procore.Endpoints.Forms.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Forms
{
    public class ListFormsOnAProjectRequest : ProcoreRequest<IEnumerable<ListFormsOnAProjectRequestResult>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/forms"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Return item(s) with the specified IDs.
        /// </summary>
        [RequestParameter("filters[id]")] public int[] Id { get; set; }

        /// <summary>
        /// Returns item(s) created by the specified User IDs.
        /// </summary>
        [RequestParameter("filters[created_by_id]")] public int[] CreatedById { get; set; }

        /// <summary>
        /// Array of Form Template IDs. Return item(s) associated with the specified Form Template IDs.
        /// </summary>
        [RequestParameter("filters[form_template_id]")] public int[] FormTemplateId { get; set; }

        /// <summary>
        /// Returns item(s) matching the specified search query string.
        /// </summary>
        [RequestParameter("filters[search]")] public string Search { get; set; }

        /// <summary>
        /// Return item(s) created within the specified ISO 8601 datetime range.
        /// </summary>
        [RequestParameter("filters[created_at]")] public string CreatedAt { get; set; }

        /// <summary>
        /// Return item(s) last updated within the specified ISO 8601 datetime range.
        /// </summary>
        [RequestParameter("filters[updated_at]")] public string UpdatedAt { get; set; }

        [RequestParameter("sort")] public string Sort { get; set; }
    }
}
