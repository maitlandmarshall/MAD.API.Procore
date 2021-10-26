using MAD.API.Procore.Endpoints.EmailCommunications.Models;
using MAD.API.Procore.Requests;
namespace MAD.API.Procore.Endpoints.EmailCommunications
{
    public class ShowEmailCommunicationRequest : ProcoreRequest<ShowEmailCommunicationRequestResult>
    {

        public override string Resource { get => $"/project/{ProjectId}/email_communications/{Id}"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// Communication ID
        /// </summary>
        [RequestParameter("id")] public long? Id { get; set; }
    }
}
