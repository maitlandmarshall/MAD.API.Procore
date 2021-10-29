using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.EmailCommunications.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.EmailCommunications {
	public class ShowEmailCommunicationRequest : ProcoreRequest<EmailCommunication> {

		public override string Resource { get => $"/project/{this.ProjectId}/email_communications/{this.Id}";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Communication ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }
	}
}
