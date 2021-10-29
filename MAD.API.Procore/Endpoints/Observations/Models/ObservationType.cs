using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Observations.Models {
	public class ObservationType {

		/// <summary>
		/// Observation Type ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Observation Type category
		/// </summary>
		[JsonProperty("category")]	public  string Category { get ; set; }

		/// <summary>
		/// Observation Type category (snake_case)
		/// </summary>
		[JsonProperty("category_key")]	public  string CategoryKey { get ; set; }

		/// <summary>
		/// Type name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Flag denoting if the Observation Type is available for use
		/// </summary>
		[JsonProperty("active")]	public  bool Active { get ; set; }

		/// <summary>
		/// Flag denoting if the Company is available for use
		/// </summary>
		[JsonProperty("company_active")]	public  bool CompanyActive { get ; set; }

		/// <summary>
		/// Flag denoting if the Parent is available for use
		/// </summary>
		[JsonProperty("parent_inactive")]	public  bool ParentInactive { get ; set; }

		/// <summary>
		/// Flag denoting if the in use is available for use
		/// </summary>
		[JsonProperty("in_use")]	public  bool InUse { get ; set; }

		/// <summary>
		/// kind
		/// </summary>
		[JsonProperty("kind")]	public  string Kind { get ; set; }

		/// <summary>
		/// Company's custom translations for observation type
		/// </summary>
		[JsonProperty("name_translations")]	public  NameTranslation NameTranslations { get ; set; }

		/// <summary>
		/// returns the localized observation_type name. It'll return custom traslations depending on the param sent in.
		/// </summary>
		[JsonProperty("localized_name")]	public  string LocalizedName { get ; set; }
	}
}
