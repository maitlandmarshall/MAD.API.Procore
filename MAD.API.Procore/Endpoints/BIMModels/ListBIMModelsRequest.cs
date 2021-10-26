using MAD.API.Procore.Endpoints.BIMModels.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.BIMModels
{
    public class ListBIMModelsRequest : ProcoreRequest<IEnumerable<BIMModel>>
    {

        public override string Resource { get => $"/bim_models"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// The compact view contains only ids.
        /// The extended view contains the response shown below.
        /// The normal view contains 'current_revision_id' instead of an embedded object 'current_revision'
        /// The default view is normal.
        /// </summary>
        [RequestParameter("view")] public string View { get; set; }

        /// <summary>
        /// Return item(s) with the specified IDs.
        /// </summary>
        [RequestParameter("filters[id]")] public int[] Id { get; set; }

        /// <summary>
        /// Filter item(s) with matching BIM File ids
        /// </summary>
        [RequestParameter("filters[bim_file_id]")] public long BimFileId { get; set; }

        /// <summary>
        /// Filter item(s) with or without revisions.
        /// </summary>
        [RequestParameter("filters[has_revisions]")] public bool HasRevisions { get; set; }

        /// <summary>
        /// Filter item(s) with the matching search query. The search is performed on title.
        /// </summary>
        [RequestParameter("filters[search]")] public string Search { get; set; }

        /// <summary>
        /// Sort item(s) by an attribute. The default sort is ascending. To sort in descending order, prepend the sort value with a hyphen character '-'
        /// </summary>
        [RequestParameter("sort")] public string Sort { get; set; }
    }
}