using Humanizer;
using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Collections.Generic;
using System.Text;

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
                    default:
                        throw new NotSupportedException();
                }

                return itemType;
            }

            string name;

            if (!string.IsNullOrEmpty(schemaModel.Title))
                name = schemaModel.Title;
            else if (!string.IsNullOrEmpty(schemaModel.Field))
                name = schemaModel.Field;
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
