using Humanizer;
using MAD.API.Procore.Gen;
using MAD.API.Procore.GenUI.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MAD.API.Procore.GenUI.CodeGeneration
{
    internal static class RequestCSGen
    {
        public static Dictionary<string, string> Generate(Endpoint endpoint)
        {
            StringBuilder codeGen = new StringBuilder();

            EndpointResponse okResponse = endpoint.Responses.FirstOrDefault(y => y.Status == 200);
            IEnumerable<Schema> schemas = GetNestedSchemas(okResponse.Schema);

            Dictionary<string, string> classes = new Dictionary<string, string>();

            int i = 0;
            foreach (Schema s in schemas)
            {
                try
                {
                    string className = ClassNameFactory.Create(s);

                    if (className is null)
                    {
                        if (i == 0)
                        {
                            if (s.Type.Name == "array")
                                continue;

                            className = ClassNameFactory.Create(s.Items as Schema ?? s.Properties.First() as Schema) ?? endpoint.Group.Singularize().CleanForCode();
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (className.ToLower().Contains("customfield"))
                        continue;

                    string code = ModelCSGen.Generate(s, "MAD.API.Procore.Models", className);

                    if (code is null)
                        continue;

                    classes.TryAdd(className, code);
                } 
                finally
                {
                    i++;
                }
            }

            string requestName = $"{endpoint.Summary.CleanForCode()}Request";

            Schema responseType = schemas.First();
            string requestResponseType = ClassNameFactory.Create(responseType);

            if (string.IsNullOrEmpty(requestResponseType))
                requestResponseType = ClassNameFactory.Create(responseType.Items as Schema ?? responseType.Properties.First() as Schema) ?? endpoint.Group.Singularize().CleanForCode();

            if (responseType.Type.Name == "array")
            {
                if (classes.TryGetValue(requestResponseType, out string requestResponseTypeCode))
                {
                    if (!requestResponseTypeCode.Contains("List<")
                        || requestResponseType == "ManpowerLog")
                    {
                        requestResponseType = $"IEnumerable<{requestResponseType}>";
                    }
                }

                
            }

            codeGen
                .AppendLine("using System;")
                .AppendLine("using System.Text;")
                .AppendLine("using Newtonsoft.Json;")
                .AppendLine("using Newtonsoft.Json.Linq;")
                .AppendLine("using System.Collections.Generic;")
                .AppendLine("using MAD.API.Procore.Models;")
                .AppendLine($"namespace MAD.API.Procore.Requests {{");

            codeGen.AppendLine($"\tpublic class {requestName} : ProcoreRequest<{requestResponseType}> {{");

            string[] endpointPathSegments = endpoint.Path.Split("/");
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

            codeGen.AppendLine($"\t\tpublic override string Resource {{ get => $\"{string.Join("/", newPathSegments)}\"; }}");

            foreach (BaseParam pp in endpoint.PathParams)
            {
                if (string.IsNullOrEmpty(pp.Name))
                    continue;

                string code = GenerateParamString(pp, false);

                codeGen.AppendLine();
                codeGen.AppendLine(code);
            }

            foreach (BaseParam qp in endpoint.QueryParams)
            {
                if (string.IsNullOrEmpty(qp.Name))
                    continue;

                if (qp.Name == "page"
                    || qp.Name == "per_page")
                    continue;

                codeGen.AppendLine();
                codeGen.AppendLine(GenerateParamString(qp, true));
            }


            codeGen.AppendLine("\t}");
            codeGen.AppendLine("}");

            classes[requestName] = codeGen.ToString();

            return classes;
        }

        private static string GenerateParamString(BaseParam param, bool isQueryParam)
        {
            StringBuilder codeGen = new StringBuilder();

            codeGen.AppendLine("\t\t/// <summary>");
            codeGen.AppendLine($"\t\t/// {param.Description}");
            codeGen.AppendLine("\t\t/// </summary>");

            if (isQueryParam)
                codeGen.AppendLine($"\t\t[RequestParameter(\"{param.Name}\")]");

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
                case "boolean":
                    type = "bool";
                    break;
                default:
                    throw new NotImplementedException();
            }

            codeGen.AppendLine($"\t\tpublic {type}{(param.Required == false ? "?" : "")} {param.Name.CleanForCode()} {{ get; set; }}");

            return codeGen.ToString();
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
