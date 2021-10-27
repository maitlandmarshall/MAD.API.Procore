using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Submittals.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Submittals {
	public class ListSubmittalsOnAProjectRequest : ProcoreRequest<IEnumerable<ListSubmittalsOnAProjectRequestResult>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/submittals";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")]	public  int[]? Id { get ; set; }

		/// <summary>
		/// User ID. Return item(s) where the specified User ID is the Ball in Court.
		/// </summary>
		[RequestParameter("filters[ball_in_court_id]")]	public  long? BallInCourtId { get ; set; }

		/// <summary>
		/// Return item(s) created within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string? CreatedAt { get ; set; }

		/// <summary>
		/// Return item(s) containing search query
		/// </summary>
		[RequestParameter("filters[query]")]	public  string? Query { get ; set; }

		/// <summary>
		/// Received From ID
		/// </summary>
		[RequestParameter("filters[received_from_id]")]	public  long? ReceivedFromId { get ; set; }

		/// <summary>
		/// Responsible Contractor ID
		/// </summary>
		[RequestParameter("filters[responsible_contractor_id]")]	public  long? ResponsibleContractorId { get ; set; }

		/// <summary>
		/// Array of Specification Section IDs. A single Specification Section ID is also accepted.
		/// </summary>
		[RequestParameter("filters[specification_section_id]")]	public  int[]? SpecificationSectionId { get ; set; }

		/// <summary>
		/// Array of User IDs. Return item(s) where the specified User IDs are in the approver list. A single integer is also accepted.
		/// </summary>
		[RequestParameter("filters[approver_id]")]	public  int[]? ApproverId { get ; set; }

		/// <summary>
		/// Default false. If true, only current revisions are shown. If false, all submittals are shown, regardless of whether or not it is the current revision.
		/// </summary>
		[RequestParameter("filters[current_revision]")]	public  bool? CurrentRevision { get ; set; }

		/// <summary>
		/// Array of Divisions to filter on. A Division is the first two digits from the Specification Section Number. A single Division is also accepted.
		/// </summary>
		[RequestParameter("filters[division]")]	public  int[]? Division { get ; set; }

		/// <summary>
		/// Array of Location IDs. A single Location ID is also accepted.
		/// </summary>
		[RequestParameter("filters[location_id]")]	public  int[]? LocationId { get ; set; }

		/// <summary>
		/// Array of Submittal Manager IDs. A single Submittal Manager ID is also accepted.
		/// </summary>
		[RequestParameter("filters[submittal_manager_id]")]	public  int[]? SubmittalManagerId { get ; set; }

		/// <summary>
		/// Array of Submittal Package IDs. Returns item(s) associated with the specified Submittal Package IDs. A single integer value is also accepted.
		/// </summary>
		[RequestParameter("filters[submittal_package_id]")]	public  int[]? SubmittalPackageId { get ; set; }

		/// <summary>
		/// Array of Response IDs. A single Response ID is also accepted.
		/// </summary>
		[RequestParameter("filters[response_id]")]	public  int[]? ResponseId { get ; set; }

		/// <summary>
		/// Array of Status IDs. A single Status ID is also accepted.
		/// </summary>
		[RequestParameter("filters[status_id]")]	public  int[]? StatusId { get ; set; }

		/// <summary>
		/// Array of Submittal Types. A single Submittal Type is also accepted.
		/// </summary>
		[RequestParameter("filters[type]")]	public  int[]? Type { get ; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string? UpdatedAt { get ; set; }

		[RequestParameter("sort")]	public  string? Sort { get ; set; }
	}
}
