using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Gen
{
    public class EndpointModel
    {
        public string Path { get; set; }
        public JToken Group { get; set; }
        public IEnumerable<EndpointResponseModel> Responses { get; set; }
        public string Verb { get; set; }
    }
}
