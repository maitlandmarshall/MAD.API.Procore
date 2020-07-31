using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Models;
namespace MAD.API.Procore.Requests {
	public class ListProjectPeopleRequest : ProcoreRequest<ArrayOfProjectPeople> {

		public override string Resource { get => $"/vapid/projects/{this.ProjectId}/people";}

		/// <summary>
		/// ID of the project
		/// </summary>
		[RequestParameter("project_id")]	public  long? ProjectId { get ; set; }

		/// <summary>
		/// Filter by is_employee value.
		/// </summary>
		[RequestParameter("filters[is_employee]")]	public  bool IsEmployee { get ; set; }

		/// <summary>
		/// Only return people who are reference users.
		/// </summary>
		[RequestParameter("filters[reference_users_only]")]	public  bool ReferenceUsersOnly { get ; set; }

		/// <summary>
		/// Return people on the company not just the project. This option only works if the user has permission to create people in the project directory or permission to read from the company directory.
		/// </summary>
		[RequestParameter("filters[include_company_people]")]	public  bool IncludeCompanyPeople { get ; set; }

		/// <summary>
		/// Search query
		/// </summary>
		[RequestParameter("filters[search]")]	public  string Search { get ; set; }
	}
}
