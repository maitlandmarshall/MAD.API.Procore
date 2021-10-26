using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListInspectorsRequest : ProcoreRequest<ListInspectorsRequestResult>
    {

        public override string Resource { get => $"/checklist/possible_inspectors"; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}
