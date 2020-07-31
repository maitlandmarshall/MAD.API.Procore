using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal class Schema : ISchema, ISchemaProperty, ISchemaObject, ISchemaArray
    {
        public string Title { get; set; }
        public string Description { get; set; }

        [JsonProperty("type")]
        public JToken TypeToken { get; set; }
        public SchemaType Type
        {
            get
            {
                if (TypeToken is JArray jArray)
                {
                    return new SchemaType
                    {
                        Name = jArray.First?.ToString(),
                        IsNullable = jArray.Last?.ToString() == "null"
                    };
                }
                else
                {
                    return new SchemaType
                    {
                        Name = TypeToken?.ToString(),
                        IsNullable = false
                    };
                }
            }
        }

        public string Field { get; set; }
        public string Format { get; set; }

        [JsonConverter(typeof(ConcreteTypeConverter<List<Schema>>))]
        public IEnumerable<ISchemaProperty> Properties { get; set; }

        [JsonConverter(typeof(ConcreteTypeConverter<Schema>))]
        public ISchemaObject Items { get; set; }
    }
}