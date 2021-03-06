using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ShowChecklistItemRequest : ProcoreRequest<ChecklistSectionItem> {

		public override string Resource { get => $"/vapid/checklist/lists/{this.ListId}/items/{this.Id}";}

		/// <summary>
		/// Checklist ID
		/// </summary>
		[RequestParameter("list_id")]	public  long? ListId { get ; set; }

		/// <summary>
		/// Item ID
		/// </summary>
		[RequestParameter("id")]	public  long? Id { get ; set; }

		/// <summary>
		/// Project ID
		/// </summary>
		[RequestParameter("project_id")]	public  long? ProjectId { get ; set; }

		/// <summary>
		/// Checklist Section ID
		/// </summary>
		[RequestParameter("section_id")]	public  long? SectionId { get ; set; }
	}
}
