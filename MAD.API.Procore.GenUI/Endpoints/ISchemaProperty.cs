using Newtonsoft.Json.Linq;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal interface ISchemaProperty
    {
        JToken TypeToken { get; }
        string Format { get; set; }
        string Description { get; }
        string Field { get; set; }
    }
}
