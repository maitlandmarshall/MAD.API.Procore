using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssueStatusTotals.Models {
	public class ShowCoordinationIssueCountByStatusRequestResult {

		/// <summary>
		/// Count of issues with status 'open'
		/// </summary>
		[JsonProperty("open_count")]	public  int? OpenCount { get ; set; }

		/// <summary>
		/// Count of issues with status 'blocked'
		/// </summary>
		[JsonProperty("blocked_count")]	public  int? BlockedCount { get ; set; }

		/// <summary>
		/// Count of issues with status 'unblocked'
		/// </summary>
		[JsonProperty("unblocked_count")]	public  int? UnblockedCount { get ; set; }

		/// <summary>
		/// Count of issues with status 'ready_for_review'
		/// </summary>
		[JsonProperty("ready_for_review_count")]	public  int? ReadyForReviewCount { get ; set; }

		/// <summary>
		/// Count of issues with status 'moved_to_observation'
		/// </summary>
		[JsonProperty("moved_to_observation_count")]	public  int? MovedToObservationCount { get ; set; }

		/// <summary>
		/// Count of issues with status 'closed'
		/// </summary>
		[JsonProperty("closed_count")]	public  int? ClosedCount { get ; set; }
	}
}
