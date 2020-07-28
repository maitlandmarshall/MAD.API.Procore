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
    class Program
    {
        const string EndpointUrl = "http://procore-api-documentation-staging.s3-website-us-east-1.amazonaws.com/";

        static HttpClient client = new HttpClient();

        static Uri GetRelativeUri(string uri)
        {
            return new Uri(new Uri(EndpointUrl), uri);
        }

        static async Task<T> GetJsonFile<T>(string file)
        {
            string json = await client.GetStringAsync(GetRelativeUri($"master/{file.Replace("(", "").Replace(")", "")}.json"));
            return JsonConvert.DeserializeObject<T>(json);
        }

        static async Task Main(string[] args)
        {
            var groups = await GetJsonFile<IEnumerable<GroupModel>>("groups");

            foreach (var grp in groups)
            {
                var alreadySnakeCase = new Regex("/^[a-z_]*$/").IsMatch(grp.Name);

                string gelatoGroup = alreadySnakeCase ?
                    grp.Name :
                    grp.Name.Replace(" ", "-").ToLower();

                var endpointModels = await GetJsonFile<IEnumerable<EndpointModel>>(gelatoGroup);
                var schemas = endpointModels
                    .SelectMany(y => y.Responses)
                    .Where(y => y.Status == 200)
                    .Select(y => y.Schema);

                foreach (var r in schemas)
                {
                    if (r.Items != null)
                    {
                        await GenerateCode(r.Items);
                    }
                    else
                    {
                        await GenerateCode(r);
                    }
                }
            }
        }

        static IDictionary<string, string> schemaCode = new Dictionary<string, string>();
        static async Task GenerateCode(EndpointResponseSchemaModel schemaModel)
        {
            if (string.IsNullOrEmpty(schemaModel.Title))
                return;

            if (schemaModel.Title.StartsWith("array"))
                return;

            if (schemaCode.ContainsKey(schemaModel.Title))
                return;

            string generatedCode = new CSGen().Generate(schemaModel, "MAD.API.Procore.Models");

            Console.WriteLine(generatedCode);

            schemaCode.Add(schemaModel.Title, generatedCode);
            string fileName = schemaModel.Title.Pascalize() + ".cs";

            string dirToWriteFiles = Path.Combine(Directory.GetCurrentDirectory(), "Gen");
            Directory.CreateDirectory(dirToWriteFiles);

            File.WriteAllText(Path.Combine(dirToWriteFiles, fileName), generatedCode);
        }
    }
}
