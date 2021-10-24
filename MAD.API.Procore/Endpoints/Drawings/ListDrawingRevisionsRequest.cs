using MAD.API.Procore.Endpoints.Drawings.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Drawings
{
    public class ListDrawingRevisionsRequest : ProcoreRequest<IEnumerable<DrawingRevision>>
    {

        public override string Resource { get => $"/projects/{ProjectId}/drawing_revisions"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Filter by Drawing Area
        /// </summary>
        [RequestParameter("drawing_area_id")] public long DrawingAreaId { get; set; }

        /// <summary>
        /// Filter by Drawing
        /// </summary>
        [RequestParameter("drawing_id")] public long DrawingId { get; set; }

        /// <summary>
        /// Filter by Drawing Discipline
        /// </summary>
        [RequestParameter("drawing_discipline_id")] public long DrawingDisciplineId { get; set; }

        /// <summary>
        /// Filter by Drawing Set.
        /// To retreive revisions from current set add `drawing_set_id=current_set` to query
        /// </summary>
        [RequestParameter("drawing_set_id")] public long DrawingSetId { get; set; }

        /// <summary>
        /// Filter by Drawing Revision ID
        /// To request specific drawing revision ids add `id[]=42&id[]=43` to query
        /// </summary>
        [RequestParameter("id")] public int[] Id { get; set; }

        /// <summary>
        /// Filter by Drawing Revisions ID
        /// To request specific drawing revision ids add `filters[ids]=[1,2,3]` to filters
        /// </summary>
        [RequestParameter("filters[ids]")] public int[] Ids { get; set; }

        /// <summary>
        /// Filter by `reviewed` status
        /// </summary>
        [RequestParameter("is_reviewed")] public bool IsReviewed { get; set; }

        /// <summary>
        /// Filter by custom query
        /// </summary>
        [RequestParameter("query")] public string Query { get; set; }

        /// <summary>
        /// Include obsolete drawing revisions. Obsolete drawing revisions are filtered by default.
        /// </summary>
        [RequestParameter("with_obsolete")] public bool WithObsolete { get; set; }
    }
}
