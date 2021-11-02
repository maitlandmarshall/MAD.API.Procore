using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.RFIs.Models {
	public class ListRFIsRequestResultQuestion {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Body
		/// </summary>
		[JsonProperty("body")]	public  string Body { get ; set; }

		/// <summary>
		/// Errors
		/// </summary>
		[JsonProperty("errors")]	public  List<ListRFIsRequestResultQuestionError> Errors { get ; set; }
	}
}
