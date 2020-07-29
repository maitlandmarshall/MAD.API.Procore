using Humanizer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MAD.API.Procore.Gen
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var groups = await RemoteJsonFile.GetJsonFile<IEnumerable<GroupModel>>("groups");
            IDictionary<string, EndpointResponseSchemaModel> allSchemas = new Dictionary<string, EndpointResponseSchemaModel>();

            foreach (var grp in groups)
            {
                var alreadySnakeCase = new Regex("/^[a-z_]*$/").IsMatch(grp.Name);

                string gelatoGroup = alreadySnakeCase ?
                    grp.Name :
                    grp.Name.Replace(" ", "-").ToLower();

                var endpointModels = await RemoteJsonFile.GetJsonFile<IEnumerable<EndpointModel>>(gelatoGroup);
                var schemas = GetSchemasFromEndpointModels(endpointModels);

                foreach (var r in schemas)
                {
                    foreach(var ns in GetNestedSchemas(r))
                    {
                        string name = ClassNameFactory.Create(ns);

                        if (string.IsNullOrEmpty(name))
                            continue;

                        if (name.ToLower().StartsWith("customfield"))
                            continue;

                        allSchemas.TryAdd(name, ns);
                    }
                }
            }

            foreach (var s in allSchemas)
            {
                await GenerateCode(s.Value, s.Key);
            }
        }

        public static IEnumerable<EndpointResponseSchemaModel> GetSchemasFromEndpointModels(IEnumerable<EndpointModel> endpointModels)
        {
            return endpointModels
                    .Where(y => y.Verb.ToLower() == "get")
                    .SelectMany(y => y.Responses)
                    .Where(y => y.Status == 200)
                    .Select(y => y.Schema);
        }

        public static IEnumerable<EndpointResponseSchemaModel> GetNestedSchemas(EndpointResponseSchemaModel schemaModel)
        {
            if (schemaModel.Type?.ToString() == "object"
                || schemaModel.Type?.ToString() == "array")
                yield return schemaModel;

            if (schemaModel.Properties != null)
            {
                foreach (var s in schemaModel.Properties)
                {
                    foreach (var ns in GetNestedSchemas(s))
                        yield return ns;
                }
            }

            if (schemaModel.Items != null)
            {
                foreach (var s in GetNestedSchemas(schemaModel.Items))
                    yield return s;
            }
        }

        public static async Task GenerateCode(EndpointResponseSchemaModel schemaModel, string className)
        {
            string generatedCode = CSGen.Generate(schemaModel, "MAD.API.Procore.Models", className);

            if (string.IsNullOrEmpty(generatedCode))
                return;

            string fileName = className + ".cs";

            string dirToWriteFiles = Path.Combine(Globals.OutputPath, "Gen");
            Directory.CreateDirectory(dirToWriteFiles);

            File.WriteAllText(Path.Combine(dirToWriteFiles, fileName), generatedCode);
        }
    }
}
