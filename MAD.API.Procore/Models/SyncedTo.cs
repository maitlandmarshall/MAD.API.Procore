using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class SyncedTo {

		/// <summary>
		/// Company ID
		/// </summary>
		[JsonProperty("company_id")]	public  int? CompanyId { get ; set; }

		/// <summary>
		/// Company List Template ID that List Template is Synced to
		/// </summary>
		[JsonProperty("list_template_id")]	public  int? ListTemplateId { get ; set; }
	}
}
