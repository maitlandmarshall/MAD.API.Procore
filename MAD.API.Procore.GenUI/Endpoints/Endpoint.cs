﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal class Endpoint
    {
        [JsonProperty("group")]
        public JToken GroupToken { get; set; }
public string Group
        {
            get
            {
                if (GroupToken is JArray jArray)
                    return jArray.First?.ToString();
                else
                {
                    return GroupToken.ToString();
                }
            }
        }

        public string Verb { get; set; }

        public string Path { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }

        [JsonProperty("base_path")]
        public string BasePath { get; set; }

        [JsonProperty("path_params")]
        public List<BaseParam> PathParams { get; set; }

        [JsonProperty("query_params")]
        public List<BaseParam> QueryParams { get; set; }

        [JsonProperty("body_params")]
        public List<BaseParam> BodyParams { get; set; }

        public List<EndpointResponse> Responses { get; set; }
    }
}
