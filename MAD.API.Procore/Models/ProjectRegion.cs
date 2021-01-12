using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class ProjectRegion {

		/// <summary>
		/// Project Region ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Project Region name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		public int CompanyId { get; set; }
		public Company Company { get; set; }
	}
}
