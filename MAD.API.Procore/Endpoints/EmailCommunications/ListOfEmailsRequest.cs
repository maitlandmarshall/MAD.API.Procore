using MAD.API.Procore.Endpoints.EmailCommunications.Models;

namespace MAD.API.Procore.Endpoints.EmailCommunications
{
    public class ListOfEmailsRequest : ProcoreRequest<ListOfEmailsRequestResult>
    {

        public override string Resource { get => $"/project/{ProjectId}/email_communications/emails"; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [RequestParameter("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// The type of the topic to be associated with the communication
        /// </summary>
        [RequestParameter("topic_type")] public string TopicType { get; set; }

        /// <summary>
        /// Topic ID
        /// </summary>
        [RequestParameter("topic_id")] public long? TopicId { get; set; }
    }
}
