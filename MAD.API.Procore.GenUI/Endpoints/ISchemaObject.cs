using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal interface ISchemaObject
    {
        string Title { get; }
        JToken TypeToken { get; }

        IEnumerable<ISchemaProperty> Properties { get; set; }
    }
}
