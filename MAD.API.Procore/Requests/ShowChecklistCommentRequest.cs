using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ShowChecklistCommentRequest : ProcoreRequest<ChecklistComment> {

		public override string Resource { get => $"/checklist/lists/{this.ListId}/comments/{this.Id}";}

		/// <summary>
		/// Checklist ID
		/// </summary>
		[RequestParameter("list_id")]	public  long? ListId { get ; set; }

		/// <summary>
		/// Comment ID
		/// </summary>
		[RequestParameter("id")]	public  long? Id { get ; set; }

		/// <summary>
		/// Project ID
		/// </summary>
		[RequestParameter("project_id")]	public  long? ProjectId { get ; set; }
	}
}
