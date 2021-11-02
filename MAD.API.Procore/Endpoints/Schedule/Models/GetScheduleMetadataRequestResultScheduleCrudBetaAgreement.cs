using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Schedule.Models {
	public class GetScheduleMetadataRequestResultScheduleCrudBetaAgreement {

		[JsonProperty("signed")]	public  bool Signed { get ; set; }

		[JsonProperty("version")]	public  string Version { get ; set; }
	}
}
