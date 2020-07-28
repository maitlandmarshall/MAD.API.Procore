using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MAD.API.Procore.Gen
{
    public class EndpointResponseSchemaModel
    {
        public string Description { get; set; }
        public JToken Example { get; set; }
        public string Field { get; set; }
        public JToken Type { get; set; }
        public string Format { get; set; }

        public string Title { get; set; }

        public IEnumerable<EndpointResponseSchemaModel> Properties { get; set; }
        public EndpointResponseSchemaModel Items { get; set; }
    }
}