using CSCodeGen;
using Humanizer;
using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Linq;
using System.Text;

namespace MAD.API.Procore.Gen
{
    internal static class ModelCSGen
    {
        private static void SerializeObject(Schema schema, ClassModel classModel)
        {
            if (schema.Properties is null)
                return;

            foreach (Schema p in schema.Properties.Cast<Schema>())
            {
                if (string.IsNullOrEmpty(p.Type.Name)
                    || p.Type.Name == "null")
                    continue;

                PropertyModel pm = new PropertyModel
                {
                    Name = p.Field.CleanForCode(),
                    Attributes =
                    {
                        $"JsonProperty(\"{p.Field}\")"
                    },
                    Comment = p.Description
                };

                switch (p.Type.Name)
                {
                    case "integer":
                        if (pm.Name == "Id"
                            || pm.Name.EndsWith("Id"))
                        {
                            pm.Type = "long";
                        }
                        else
                        {
                            pm.Type = "int";
                        }

                        break;
                    case "boolean":
                        pm.Type = "bool";
                        break;
                    case "string":
                        if (p.Format == "date-time")
                        {
                            pm.Type = "DateTimeOffset";
                        }
                        else
                        {
                            pm.Type = "string";
                        }

                        break;
                    case "object":
                        string objClassName = ClassNameFactory.Create(p);

                        if (objClassName.ToLower() == "customfields")
                            continue;

                        if (objClassName.ToLower() == "customfield")
                        {
                            objClassName = "JObject";
                        }

                        pm.Type = objClassName;
                        break;
                    case "array":
                        if (p.Items is Schema itemsSchema)
                        {
                            string arrayItemName = ClassNameFactory.Create(itemsSchema);

                            if (string.IsNullOrEmpty(arrayItemName))
                            {
                                arrayItemName = ClassNameFactory.Create(p);
                            }

                            pm.Type = $"List<{arrayItemName}>";
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }

                        break;
                    case "number":
                        pm.Type = "decimal";
                        break;
                    default:
                        throw new NotImplementedException();
                }

                if (p.Type.IsNullable
                    || p.Type.Name == "number"
                    || (p.Type.Name == "integer" && p.Field != "id")
                    || (p.Format == "date-time" && (!p.Field.StartsWith("created") && !p.Field.StartsWith("updated"))))
                    pm.IsNullable = true;

                classModel.Properties.Add(pm);
            }
        }

        public static ClassModel Generate(Schema schema, string ns, string className)
        {
            ClassModel classModel = new ClassModel
            {
                Usings =
                {
                    "System.Text",
                    "Newtonsoft.Json",
                    "Newtonsoft.Json.Linq",
                    "System",
                    "System.Collections.Generic"
                },
                Name = className,
                Namespace = ns
            };

            if (schema.Items is null)
            {
                SerializeObject(schema, classModel);
            }
            else
            {
                if (schema.Items.Properties != null
                    && schema.Items.Title is null)
                {
                    SerializeObject(schema.Items as Schema, classModel);
                }
                else
                {
                    var itemsSchema = schema.Items as Schema;
                    var arrayItemClass = ClassNameFactory.Create(itemsSchema);

                    if (arrayItemClass.Contains("null"))
                        return null;

                    classModel.BaseClass = new ClassModel
                    {
                        Name = "List",
                        Generics = {
                            arrayItemClass
                        }
                    };
                }
            }

            return classModel;
        }
    }
}
