using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ProjectCompany {

		/// <summary>
		/// Company ID
		/// </summary>
		[JsonProperty("id")]	public  int CompanyId { get ; set; }

		public int ProjectId { get; set; }

		/// <summary>
		/// Company name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		public Project Project { get; set; }
		public Company Company { get; set; }
	}
}
