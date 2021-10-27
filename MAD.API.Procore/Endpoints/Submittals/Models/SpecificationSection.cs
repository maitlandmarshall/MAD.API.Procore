using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Submittals.Models {
	public class SpecificationSection {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Number
		/// </summary>
		[JsonProperty("number")]	public  string Number { get ; set; }

		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Label
		/// </summary>
		[JsonProperty("label")]	public  string Label { get ; set; }

		/// <summary>
		/// Current Revision ID
		/// </summary>
		[JsonProperty("current_revision_id")]	public  long? CurrentRevisionId { get ; set; }
	}
}
