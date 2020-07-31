using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Linq;
using System.Text;

namespace MAD.API.Procore.Gen
{
    internal static class CSGen
    {
        private static void SerializeObject(Schema schema, StringBuilder codeBuilder)
        {
            codeBuilder.AppendLine(" {");

            if (schema.Properties is null)
                return;

            foreach (Schema p in schema.Properties.Cast<Schema>())
            {
                if (string.IsNullOrEmpty(p.Type.Name)
                    || p.Type.Name == "null")
                    continue;

                codeBuilder.AppendLine($"\t\t[JsonProperty(\"{p.Field}\")]");
                codeBuilder.Append($"\t\tpublic ");

                switch (p.Type.Name)
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
                        codeBuilder.Append(ClassNameFactory.Create(p));
                        break;
                    case "array":
                        if (p.Items != null)
                        {
                            codeBuilder
                            .Append(ClassNameFactory.Create(p.Items as Schema))
                            .Append("[]");
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }

                        break;
                    case "number":
                        codeBuilder.Append("decimal");
                        break;
                    default:
                        throw new NotImplementedException();
                }

                if (p.Type.IsNullable)
                    codeBuilder.Append("?");

                codeBuilder.AppendLine($" {p.Field.CleanForCode()} {{ get; set; }}");
            }
        }

        public static string Generate(Schema schema, string ns, string className)
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
                    SerializeObject(schema.Items as Schema, codeBuilder);
                }
                else
                {
                    string arrayItemClass = ClassNameFactory.Create(schema.Items as Schema)
                        ?? (schema.Items as Schema).Type?.ToString().CleanForCode();

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
