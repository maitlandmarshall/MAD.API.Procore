using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAD.API.Procore.Gen.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var endpointModels = await RemoteJsonFile.GetJsonFile<IEnumerable<EndpointModel>>("checklists");
            var schemas = Program.GetSchemasFromEndpointModels(endpointModels);
            
            foreach (var x in schemas)
            {
                var nested = Program.GetNestedSchemas(x);

                foreach (var y in nested)
                {
                    string generatedCode = CSGen.Generate(y, "MAD.API.Procore.Models", ClassNameFactory.Create(y));
                }

                
            }
        }
    }
}
