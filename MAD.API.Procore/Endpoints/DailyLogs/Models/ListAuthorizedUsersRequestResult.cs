using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.DailyLogs.Models {
	public class ListAuthorizedUsersRequestResult {

		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
