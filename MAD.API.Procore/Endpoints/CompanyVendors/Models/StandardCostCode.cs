using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.CompanyVendors.Models {
	public class StandardCostCode {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Standard Cost Code List ID
		/// </summary>
		[JsonProperty("standard_cost_code_list_id")]	public  long? StandardCostCodeListId { get ; set; }

		/// <summary>
		/// Parent ID
		/// </summary>
		[JsonProperty("parent_id")]	public  long? ParentId { get ; set; }

		/// <summary>
		/// Cost code, not including parent prefix
		/// </summary>
		[JsonProperty("code")]	public  string Code { get ; set; }

		/// <summary>
		/// Cost code, including parent prefixes
		/// </summary>
		[JsonProperty("full_code")]	public  string FullCode { get ; set; }

		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Origin data
		/// </summary>
		[JsonProperty("origin_data")]	public  string OriginData { get ; set; }

		/// <summary>
		/// Origin ID
		/// </summary>
		[JsonProperty("origin_id")]	public  string OriginId { get ; set; }
	}
}
