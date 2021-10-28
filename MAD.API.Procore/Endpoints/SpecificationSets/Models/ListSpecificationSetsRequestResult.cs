using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.SpecificationSets.Models {
	public class ListSpecificationSetsRequestResult {

		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("name")]	public  string Name { get ; set; }

		[JsonProperty("date")]	public  string Date { get ; set; }

		[JsonProperty("position")]	public  int? Position { get ; set; }
	}
}
