using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CoordinationIssueStatusChanges.Models {
	public class ItemDatum {

		[JsonProperty("has_official_response")]	public  bool HasOfficialResponse { get ; set; }

		[JsonProperty("subject")]	public  string Subject { get ; set; }

		[JsonProperty("number")]	public  string Number { get ; set; }
	}
}
