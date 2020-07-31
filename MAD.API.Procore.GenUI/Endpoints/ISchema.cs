using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal interface ISchema
    {
        string Description { get; }

        JToken TypeToken { get; }
    }
}
