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

            string name;

            if (!string.IsNullOrEmpty(schemaModel.Title))
                name = schemaModel.Title;
            else if (!string.IsNullOrEmpty(schemaModel.Field))
            {
                if (schemaModel.Parent != null
                    && schemaModel.Field != "custom_field"
                    && schemaModel.Field != "custom_fields")
                {
                    // Unless the model has a specific title, the name should be a concatenation of its parent's name and its field
                    name = $"{Create(schemaModel.Parent as Schema)}_{schemaModel.Field}";
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

            else if (schemaModel.Parent != null)
                return Create(schemaModel.Parent as Schema);
            else if (schemaModel.Endpoint != null)
                name = schemaModel.Endpoint.Summary + "RequestResult";
            else
                return null;

            return name.CleanForCode().Singularize();
        }
    }
}
