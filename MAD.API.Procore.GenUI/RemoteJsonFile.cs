using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MAD.API.Procore.Gen
{
    public static class RemoteJsonFile
    {
        static Uri GetRelativeUri(string uri)
        {
            return new Uri(new Uri(Globals.EndpointUrl), uri);
        }

        public static async Task<T> GetJsonFile<T>(string file)
        {
            string fileName = $"{file.Replace("(", "").Replace(")", "")}.json";
            string filePath = Path.Combine(Globals.OutputPath, "json", fileName);
            string json;

            if (File.Exists(filePath))
            {
                json = await File.ReadAllTextAsync(filePath);
            }
            else
            {
                json = await Globals.HttpClient.GetStringAsync(GetRelativeUri(fileName));

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                await File.WriteAllTextAsync(filePath, json);
            }

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
