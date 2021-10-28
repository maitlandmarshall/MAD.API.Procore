using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Meetings.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Meetings {
	public class ShowMeetingRequest : ProcoreRequest<Meeting> {

		public override string Resource { get => $"/meetings/{this.Id}";}

		/// <summary>
		/// ID of the meeting
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
