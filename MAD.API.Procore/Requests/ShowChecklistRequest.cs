using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ShowChecklistRequest : ProcoreRequest<Checklist> {

		public override string Resource { get => $"/checklist/lists/{this.Id}";}

		/// <summary>
		/// Checklist ID
		/// </summary>
		[RequestParameter("id")]	public  long? Id { get ; set; }

		/// <summary>
		/// Project ID
		/// </summary>
		[RequestParameter("project_id")]	public  long? ProjectId { get ; set; }
	}
}
