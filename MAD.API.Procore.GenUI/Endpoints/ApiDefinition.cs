using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal class ApiDefinition
    {
        [JsonProperty("api_version")]
        public double ApiVersion { get; set; }

        public IEnumerable<ApiVersion> Versions { get; set; }
    }

    internal class ApiVersion
    {
        [JsonProperty("api_version")]
        public double Version { get; set; }

        public string Name { get; set; }
        public IEnumerable<Endpoint> Endpoints { get; set; }
    }
}
