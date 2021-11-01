using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.ManpowerLogs.Models {
	public class ListManpowerLogsRequestResultContact {

		[JsonProperty("id")]	public  long Id { get ; set; }

		[JsonProperty("business_phone")]	public  string BusinessPhone { get ; set; }

		[JsonProperty("business_phone_extension")]	public  int? BusinessPhoneExtension { get ; set; }

		[JsonProperty("email")]	public  string Email { get ; set; }

		[JsonProperty("fax_number")]	public  string FaxNumber { get ; set; }

		[JsonProperty("job_title")]	public  string JobTitle { get ; set; }

		[JsonProperty("login_information_id")]	public  long? LoginInformationId { get ; set; }

		[JsonProperty("mobile_phone")]	public  string MobilePhone { get ; set; }

		[JsonProperty("name")]	public  string Name { get ; set; }

		[JsonProperty("vendor_name")]	public  string VendorName { get ; set; }
	}
}
