using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.EmailCommunications.Models {
	public class Distribution {

		/// <summary>
		/// User ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Company Name
		/// </summary>
		[JsonProperty("company_name")]	public  string CompanyName { get ; set; }

		/// <summary>
		/// User dictionary
		/// </summary>
		[JsonProperty("locale")]	public  string Locale { get ; set; }

		/// <summary>
		/// Login of user
		/// </summary>
		[JsonProperty("login")]	public  string Login { get ; set; }

		/// <summary>
		/// User name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// User avatar url
		/// </summary>
		[JsonProperty("avatar")]	public  string Avatar { get ; set; }

		/// <summary>
		/// User initials
		/// </summary>
		[JsonProperty("initials")]	public  string Initials { get ; set; }
	}
}
