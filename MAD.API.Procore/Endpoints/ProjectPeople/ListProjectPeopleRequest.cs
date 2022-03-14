using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.ProjectPeople.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.ProjectPeople {
	public class ListProjectPeopleRequest : ProcorePaginatedRequest<IEnumerable<ProjectPerson>> {

		public override string Resource { get => $"/rest/v1.0/projects/{this.ProjectId}/people";}

		/// <summary>
		/// ID of the project
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// If true, returns item(s) where `is_employee` value is true.
		/// </summary>
		[RequestParameter("filters[is_employee]")]	public  bool? IsEmployee { get ; set; }

		/// <summary>
		/// If true, returns only people who are reference users.
		/// </summary>
		[RequestParameter("filters[reference_users_only]")]	public  bool? ReferenceUsersOnly { get ; set; }

		/// <summary>
		/// If true, returns people in the Company not just the Project. This option only works if the user has permission to create people in the project directory or permission to read from the company directory.
		/// </summary>
		[RequestParameter("filters[include_company_people]")]	public  bool? IncludeCompanyPeople { get ; set; }

		/// <summary>
		/// Returns item(s) matching the specified search query string.
		/// </summary>
		[RequestParameter("filters[search]")]	public  string? Search { get ; set; }
	}
}
