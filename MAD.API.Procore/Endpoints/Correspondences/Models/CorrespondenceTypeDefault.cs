using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences.Models {
	public class CorrespondenceTypeDefault {

		[JsonProperty("correspondence_type_id")]	public  long? CorrespondenceTypeId { get ; set; }

		[JsonProperty("description")]	public  string Description { get ; set; }

		[JsonProperty("due_days")]	public  int? DueDays { get ; set; }

		/// <summary>
		/// Distribution Members
		/// </summary>
		[JsonProperty("distribution_members")]	public  List<DistributionMember> DistributionMembers { get ; set; }

		[JsonProperty("available_statuses")]	public  List<string> AvailableStatuses { get ; set; }

		[JsonProperty("private_by_default")]	public  bool PrivateByDefault { get ; set; }
	}
}
