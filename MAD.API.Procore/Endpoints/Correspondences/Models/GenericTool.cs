using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Correspondences.Models {
	public class GenericTool {

		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("potential_assignee")]	public  bool PotentialAssignee { get ; set; }

		[JsonProperty("potential_received_from")]	public  bool PotentialReceivedFrom { get ; set; }

		[JsonProperty("potential_distribution_member")]	public  bool PotentialDistributionMember { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }
	}
}
