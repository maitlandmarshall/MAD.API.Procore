using Humanizer;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Gen
{
    public static class CSGen
    {
        private static void SerializeObject(EndpointResponseSchemaModel schema, StringBuilder codeBuilder)
        {
            codeBuilder.AppendLine(" {");

            if (schema.Properties is null)
                return;

            foreach (var p in schema.Properties)
            {
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

                if (string.IsNullOrEmpty(type)
                    || type == "null")
                    continue;

                codeBuilder.AppendLine($"\t\t[JsonProperty(\"{p.Field}\")]");
                codeBuilder.Append($"\t\tpublic ");

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
                            codeBuilder.Append(p.Title.CleanForCode());
                        }
                        break;
                    case "array":
                        if (!string.IsNullOrEmpty(p.Items.Title))
                        {
                            codeBuilder
                                .Append(p.Items.Title.CleanForCode())
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

                codeBuilder.AppendLine($" {p.Field.CleanForCode()} {{ get; set; }}");
            }
        }

        public static string Generate(EndpointResponseSchemaModel schema, string ns, string className)
        {
            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder
                .AppendLine("using System;")
                .AppendLine("using System.Text;")
                .AppendLine("using Newtonsoft.Json;")
                .AppendLine("using Newtonsoft.Json.Linq;")
                .AppendLine("using System.Collections.Generic;")
                .AppendLine($"namespace {ns} {{")
                .Append($"\tpublic class {className}");

            if (schema.Items is null)
            {
                SerializeObject(schema, codeBuilder);
            }
            else
            {
                if (schema.Items.Properties != null
                    && schema.Items.Title is null)
                {
                    SerializeObject(schema.Items, codeBuilder);
                }
                else
                {
                    string arrayItemClass = ClassNameFactory.Create(schema.Items)
                        ?? schema.Items.Type?.ToString().CleanForCode();

                    if (arrayItemClass.Contains("null"))
                        return null;

                    codeBuilder.AppendLine($" : List<{arrayItemClass}> {{");
                }
            }

            codeBuilder.AppendLine("\t}");
            codeBuilder.AppendLine("}");

            return codeBuilder.ToString();
        }
    }
}
