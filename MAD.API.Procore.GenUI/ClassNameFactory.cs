using Humanizer;
using MAD.API.Procore.GenUI.Endpoints;
using System;

namespace MAD.API.Procore.Gen
{
    internal static class ClassNameFactory
    {
        public static string Create(Schema schemaModel)
        {
            if (schemaModel.Type.Name != "object"
                && schemaModel.Type.Name != "array")
            {
                string itemType;

                switch (schemaModel.Type.Name)
                {
                    case "integer":
                        itemType = "long";
                        break;
                    case "string":
                        itemType = "string";
                        break;
                    default:
                        throw new NotSupportedException();
                }

                return itemType;
            }

            var model = schemaModel;
            string name;

            do
            {
                if (model.Type?.Name == "array")
                {
                    // Does the array's item type have a name?
                    name = GetName(model.Items as Schema) ?? GetName(model);
                }
                else
                {
                    name = GetName(model);
                }

                model = model.Parent as Schema;

            } while (string.IsNullOrWhiteSpace(name));

            return name;
        }

        private static string GetName(Schema schemaModel)
        {
            string name;

            if (schemaModel.Type.Name != "object"
                && schemaModel.Type.Name != "array")
            {
                string itemType;

                switch (schemaModel.Type.Name)
                {
                    case "integer":
                        itemType = "long";
                        break;
                    case "string":
                        itemType = "string";
                        break;
                    default:
                        throw new NotSupportedException();
                }

                return itemType;
            }
            else if (!string.IsNullOrEmpty(schemaModel.Title))
            {
                name = schemaModel.Title;
            }
            else if (!string.IsNullOrEmpty(schemaModel.Field))
            {
                if (schemaModel.Parent != null
                    && schemaModel.Field != "custom_field"
                    && schemaModel.Field != "custom_fields")
                {
                    // Prevent generating empty class objects with no properties when the schema provided by Procore has no properties
                    if (schemaModel.Properties is null
                        && schemaModel.Items is null)
                    {
                        return "JObject";
                    }

                    // Unless the model has a specific title, the name should be a concatenation of its parent's name and its field
                    var parentName = Create(schemaModel.Parent as Schema);

                    if (string.IsNullOrWhiteSpace(parentName))
                    {
                        name = schemaModel.Field;
                    }
                    else
                    {
                        name = $"{parentName}_{schemaModel.Field}";
                    }
                }
                else
                {
                    name = schemaModel.Field;
                }
            }
            else if (!string.IsNullOrEmpty(schemaModel.Description))
            {
                name = schemaModel.Description;

                if (schemaModel.Type.Name == "array"
                    && name.StartsWith("array of", StringComparison.InvariantCultureIgnoreCase))
                {
                    name = name.Substring("array of".Length).Trim();
                }
            }
            else if (schemaModel.Endpoint != null
                && schemaModel.Parent is null)
            {
                name = schemaModel.Endpoint.Summary + "RequestResult";
            }
            else return null;

            var finalName = name.CleanForCode().Singularize();

            return finalName;
        }
    }
}
