using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests
{
    public class ListLocationsRequest : ProcoreRequest<ArrayOfLocations>
    {

        public override string Resource { get => $"/locations"; }

        /// <summary>
        /// Project ID
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }
    }
}