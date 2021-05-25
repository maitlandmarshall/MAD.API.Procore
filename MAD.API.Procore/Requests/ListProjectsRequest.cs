using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListProjectsRequest : ProcoreRequest<ArrayOfProjects> {

		public override string Resource { get => $"/projects";}

		/// <summary>
		/// Company ID
		/// </summary>
		[RequestParameter("company_id")]	public  long? CompanyId { get ; set; }

		/// <summary>
		/// Filters on project status. Must be one of Active, Inactive, or All.
		/// </summary>
		[RequestParameter("filters[by_status]")]	public  string ByStatus { get ; set; }

		/// <summary>
		/// Return item(s) within a specific created at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string CreatedAt { get ; set; }

		/// <summary>
		/// Return item(s) within a specific updated at iso8601 datetime range
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string UpdatedAt { get ; set; }

		/// <summary>
		/// Return an item with a specific origin ID
		/// </summary>
		[RequestParameter("filters[origin_id]")]	public  string OriginId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs
		/// </summary>
		[RequestParameter("filters[id]")]	public  string[] Id { get ; set; }
	}
}
