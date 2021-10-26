using Newtonsoft.Json.Linq;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal interface ISchema
    {
        string Description { get; }

        JToken TypeToken { get; }

        ISchema Parent { get; }
    }
}
