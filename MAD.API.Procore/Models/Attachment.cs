using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Attachment {

		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Use :name, :filename to be deprecated
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		[JsonProperty("url")]	public  string Url { get ; set; }

		/// <summary>
		/// :filename to be deprecated, use :name
		/// </summary>
		[JsonProperty("filename")]	public  string Filename { get ; set; }
	}
}
