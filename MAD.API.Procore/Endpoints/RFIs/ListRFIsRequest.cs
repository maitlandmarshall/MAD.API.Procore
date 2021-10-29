using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.RFIs.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.RFIs {
	public class ListRFIsRequest : ProcorePaginatedRequest<IEnumerable<ListRFIsRequestResult>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/rfis";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")]	public  int[] Id { get ; set; }

		/// <summary>
		/// Return item(s) with the specified RFI Status.
		/// </summary>
		[RequestParameter("filters[status]")]	public  string Status { get ; set; }

		/// <summary>
		/// Assigned ID
		/// </summary>
		[RequestParameter("filters[assigned_id]")]	public  string AssignedId { get ; set; }

		/// <summary>
		/// Return item(s) created within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string CreatedAt { get ; set; }

		/// <summary>
		/// Responsible Contractor ID
		/// </summary>
		[RequestParameter("filters[responsible_contractor_id]")]	public  long? ResponsibleContractorId { get ; set; }

		/// <summary>
		/// Cost Code ID. Returns item(s) with the specified Cost Code ID or within the specified range of Cost Code IDs.
		/// </summary>
		[RequestParameter("filters[cost_code_id]")]	public  string CostCodeId { get ; set; }

		/// <summary>
		/// Received From Login Information ID. Returns item(s) with the specified Received From Login Information ID.
		/// </summary>
		[RequestParameter("filters[received_from_login_information_id]")]	public  string ReceivedFromLoginInformationId { get ; set; }

		/// <summary>
		/// User ID. Return item(s) where the specified User ID is the Ball in Court.
		/// </summary>
		[RequestParameter("filters[ball_in_court_id]")]	public  long? BallInCourtId { get ; set; }

		/// <summary>
		/// Location ID. Returns item(s) with the specified Location ID or a range of Location IDs.
		/// </summary>
		[RequestParameter("filters[location_id]")]	public  int[] LocationId { get ; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string UpdatedAt { get ; set; }

		/// <summary>
		/// Return item(s) with the specified RFI Manager ID.
		/// </summary>
		[RequestParameter("filters[rfi_manager_id]")]	public  long? RfiManagerId { get ; set; }

		/// <summary>
		/// The attribute by which to sort the list of RFIs
		/// </summary>
		[RequestParameter("sort[attribute]")]	public  string Sortattribute { get ; set; }

		/// <summary>
		/// If passed a sort attribute, determines which direction to sort
		/// </summary>
		[RequestParameter("sort[direction]")]	public  string Sortdirection { get ; set; }
	}
}
