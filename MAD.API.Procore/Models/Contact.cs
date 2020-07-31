using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Models {
	public class Contact {

		/// <summary>
		/// The active status of the Contact associated to the Project Person
		/// </summary>
		[JsonProperty("is_active")]	public  bool IsActive { get ; set; }
	}
}
