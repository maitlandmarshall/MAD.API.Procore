using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Checklists.Models {
	public class ChecklistItemResponsePayloadResponseOption {

		/// <summary>
		/// Response Option ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Response Option Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }
	}
}
