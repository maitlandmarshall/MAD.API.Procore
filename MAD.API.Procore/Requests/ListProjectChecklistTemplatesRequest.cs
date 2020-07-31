using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListProjectChecklistTemplatesRequest : ProcoreRequest<ArrayOfChecklistTemplates> {

		public override string Resource { get => $"/vapid/projects/{this.ProjectId}/checklist/list_templates";}

		/// <summary>
		/// Project ID
		/// </summary>
		[RequestParameter("project_id")]	public  long? ProjectId { get ; set; }

		/// <summary>
		/// Array of Inspection Type IDs. Return item(s) associated to the specified Inspection Type IDs.
		/// </summary>
		[RequestParameter("filters[inspection_type_id]")]	public  string[] InspectionTypeId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified Trade IDs.
		/// </summary>
		[RequestParameter("filters[trade_ids]")]	public  string[] TradeIds { get ; set; }

		/// <summary>
		/// Return item(s) containing search query
		/// </summary>
		[RequestParameter("filters[query]")]	public  string Query { get ; set; }
	}
}
