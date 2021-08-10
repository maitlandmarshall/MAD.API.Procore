using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal class BaseParam
    {
        public string Name { get; set; }
        public bool Required { get; set; }
        public string Type
        {
            get
            {
                return this.TypeImpl.ToObject<string>();
            }
        }

        public string Description { get; set; }

        [JsonProperty("type")]
        public JToken TypeImpl { get; set; }
    }
}