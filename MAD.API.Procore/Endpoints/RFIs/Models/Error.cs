using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.RFIs.Models {
	public class Error {

		[JsonProperty("errors")]	public  string Errors { get ; set; }
	}
}
