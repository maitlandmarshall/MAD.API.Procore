using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.EmailCommunications.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.EmailCommunications {
	public class ListOfEmailsRequest : ProcoreRequest<ListOfEmailsRequestResult> {

		public override string Resource { get => $"/project/{this.ProjectId}/email_communications/emails";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// The type of the topic to be associated with the communication
		/// </summary>
		[RequestParameter("topic_type")]	public  string TopicType { get ; set; }

		/// <summary>
		/// Topic ID
		/// </summary>
		[RequestParameter("topic_id")]	public  long TopicId { get ; set; }
	}
}
