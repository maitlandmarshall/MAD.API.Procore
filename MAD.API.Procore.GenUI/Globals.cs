using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MAD.API.Procore.Gen
{
    public static class Globals
    {
        public const string EndpointUrl = "https://s3-us-west-2.amazonaws.com/procore-api-documentation-production/master/rest_docs/1/";
        public const string OutputPath = @"C:\Playground\ProcoreGen";

        public static HttpClient HttpClient = new HttpClient();
    }
}
