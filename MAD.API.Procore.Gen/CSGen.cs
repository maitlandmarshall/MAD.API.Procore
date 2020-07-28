using Humanizer;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Gen
{
    public class CSGen
    {
        public string Generate(EndpointResponseSchemaModel schema, string ns)
        {
            string className = schema.Title.Pascalize();

            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder
                .AppendLine("using System;")
                .AppendLine("using System.Text;")
                .AppendLine("using Newtonsoft.Json;")
                .AppendLine($"namespace {ns} {{")
                .AppendLine($"\tpublic class {className} {{");

            foreach (var p in schema.Properties)
            {
                codeBuilder.AppendLine($"\t\t[JsonProperty(\"{p.Field}\")]");
                codeBuilder.Append($"\t\tpublic ");

                string type;
                bool isNullable;

                if (p.Type is JArray jArray)
                {
                    type = jArray.First?.ToString();
                    isNullable = jArray.Last?.ToString() == "null";
                }
                else
                {
                    type = p.Type?.ToString();
                    isNullable = false;
                }

                if (string.IsNullOrEmpty(type))
                    continue;
               
                switch (type)
                {
                    case "integer":
                        codeBuilder.Append("int");
                        break;
                    case "boolean":
                        codeBuilder.Append("bool");
                        break;
                    case "string":

                        if (p.Format == "date-time")
                        {
                            codeBuilder.Append("DateTimeOffset");
                        }
                        else
                        {
                            codeBuilder.Append("string");
                        }
                        
                        break;
                    case "object":
                        if (string.IsNullOrEmpty(p.Title))
                        {
                            codeBuilder.Append("JToken");
                        }
                        else
                        {
                            codeBuilder.Append(p.Title.Pascalize());
                        }
                        break;
                    case "array":
                        if (!string.IsNullOrEmpty(p.Items.Title))
                        {
                            codeBuilder
                                .Append(p.Items.Title.Pascalize())
                                .Append("[]");
                        }
                        else
                        {
                            codeBuilder.Append("JToken");
                        }

                        break;
                    case "number":
                        codeBuilder.Append("decimal");
                        break;
                    default:
                        throw new NotImplementedException();
                }

                if (isNullable)
                    codeBuilder.Append("?");

                codeBuilder.AppendLine($" {p.Field.Pascalize()} {{ get; set; }}");
            }

            codeBuilder.AppendLine("\t}");
            codeBuilder.AppendLine("}");

            return codeBuilder.ToString();
        }
    }
}
