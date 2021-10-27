using CSCodeGen;
using MAD.API.Procore.Gen;
using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;

namespace MAD.API.Procore.GenUI.CodeGeneration
{
    internal static class RequestCSGen
    {
        public static IEnumerable<ClassModel> Generate(Endpoint endpoint)
        {
            EndpointResponse okResponse = endpoint.Responses.FirstOrDefault(y => y.Status >= 200 && y.Status <= 299);
            IEnumerable<Schema> schemas = GetNestedSchemas(okResponse.Schema);

            IEnumerable<ClassModel> schemaClassModels = GenerateModels(schemas)
                .OrderByDescending(y => y.Properties.Count)
                .GroupBy(y => y.Name)
                .Select(y => y.First());

            Schema responseType = schemas.First();
            string requestResponseType = ClassNameFactory.Create(responseType);

            ClassModel responseTypeClassModel = schemaClassModels.First(y => y.Name == requestResponseType);

            if (responseTypeClassModel.BaseClass is null
                && responseType.Type.Name == "array")
            {
                requestResponseType = $"IEnumerable<{requestResponseType}>";
            }

            ClassModel procoreRequestModel = new ClassModel
            {
                Name = responseType.Type.Name.StartsWith("array") ? "ProcorePaginatedRequest": "ProcoreRequest",
                Generics =
                {
                    requestResponseType
                }
            };

            var requestNamespace = $"MAD.API.Procore.Endpoints.{endpoint.Group.CleanForCode()}";
            var endpointName = endpoint.Summary.CleanForCode();

            ClassModel endpointRequestModel = new ClassModel
            {
                Name = $"{endpointName}Request",
                BaseClass = procoreRequestModel,
                AccessModifier = "public",
                Usings =
                {
                    "System",
                    "System.Text",
                    "Newtonsoft.Json",
                    "Newtonsoft.Json.Linq",
                    "System.Collections.Generic",
                    $"{requestNamespace}.Models",
                    "MAD.API.Procore"
                },
                Namespace = requestNamespace
            };

            endpointRequestModel.Properties.Add(new PropertyModel
            {
                Name = "Resource",
                Getter = $"$\"{FormatResourceStringForCSharpStringInterop(endpoint.Path)}\";",
                Type = "string",
                Override = true
            });

            if (endpoint.Verb != "get")
            {
                endpointRequestModel.Usings.Add("System.Net.Http");
                endpointRequestModel.Properties.Add(new PropertyModel
                {
                    Name = nameof(HttpMethod),
                    Override = true,
                    IsNullable = false,
                    Type = nameof(HttpMethod),
                    Getter = $"HttpMethod.{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(endpoint.Verb)}"
                });
            }

            foreach (BaseParam pp in endpoint.PathParams)
            {
                if (string.IsNullOrEmpty(pp.Name))
                    continue;

                endpointRequestModel.Properties.Add(GeneratePropertyModel(pp, false));
            }

            foreach (BaseParam qp in endpoint.QueryParams)
            {
                if (string.IsNullOrEmpty(qp.Name))
                    continue;

                if (qp.Name == "page"
                    || qp.Name == "per_page")
                    continue;

                endpointRequestModel.Properties.Add(GeneratePropertyModel(qp, true));
            }

            yield return endpointRequestModel;

            foreach (ClassModel i in schemaClassModels)
            {
                yield return i;
            }
        }

        private static string FormatResourceStringForCSharpStringInterop(string resource)
        {
            string[] endpointPathSegments = resource.Split("/");
            List<string> newPathSegments = new List<string>();

            foreach (string eps in endpointPathSegments)
            {
                if (eps.StartsWith("{"))
                {
                    string epsInner = eps.Substring(1);
                    epsInner = epsInner.Substring(0, epsInner.IndexOf("}"));

                    newPathSegments.Add($"{{this.{epsInner.CleanForCode()}}}");
                }
                else
                {
                    newPathSegments.Add(eps);
                }
            }

            return string.Join("/", newPathSegments);
        }

        private static IEnumerable<ClassModel> GenerateModels(IEnumerable<Schema> schemas)
        {
            int i = 0;
            foreach (Schema s in schemas)
            {
                var sItems = s.Items as Schema;

                try
                {
                    if (s.Type.Name == "array"
                        && sItems.Type.Name != "object"
                        && sItems.Type.Name != "array")
                        continue;

                    string className = ClassNameFactory.Create(s);

                    if (className is null)
                        continue;

                    if (className.ToLower().Contains("customfield"))
                        continue;

                    var ns = s.Endpoint.Group.CleanForCode();

                    ClassModel gen = ModelCSGen.Generate(s, $"MAD.API.Procore.Endpoints.{ns}.Models", className); ;

                    if (gen is null)
                        continue;

                    yield return gen;
                }
                finally
                {
                    i++;
                }
            }
        }

        private static PropertyModel GeneratePropertyModel(BaseParam param, bool isQueryParam)
        {
            PropertyModel result = new PropertyModel
            {
                Comment = param.Description
            };

            result.Attributes.Add($"RequestParameter(\"{param.Name}\")");

            string type;

            switch (param.Type)
            {
                case "integer":
                    type = "long";
                    break;
                case "string":
                    type = "string";
                    break;
                case "array":
                    type = "string[]";
                    break;
                case "array[integer]":
                    type = "int[]";
                    break;
                case "boolean":
                    type = "bool";
                    break;
                case "array[string]":
                    type = "int[]";
                    break;
                default:
                    throw new NotImplementedException();
            }

            result.Type = type;
            result.IsNullable = param.Required == false;
            result.Name = param.Name.CleanForCode();

            return result;
        }

        private static IEnumerable<Schema> GetNestedSchemas(Schema schemaModel)
        {
            if (schemaModel.Type.Name == "object"
                || schemaModel.Type.Name == "array")
                yield return schemaModel;

            if (schemaModel.Properties != null)
            {
                foreach (ISchemaProperty s in schemaModel.Properties)
                {
                    foreach (Schema ns in GetNestedSchemas(s as Schema))
                        yield return ns;
                }
            }

            if (schemaModel.Items != null)
            {
                foreach (Schema s in GetNestedSchemas(schemaModel.Items as Schema))
                    yield return s;
            }
        }
    }
}
