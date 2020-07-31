using Newtonsoft.Json;
using System.DirectoryServices.ActiveDirectory;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal class EndpointResponse
    {
        public string Description { get; set; }
        public int Status { get; set; }

        public Schema Schema { get; set; }
    }
}