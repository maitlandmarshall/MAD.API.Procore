using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MAD.API.Procore.Gen
{
    public static class Globals
    {
        public const string EndpointUrl = "http://procore-api-documentation-staging.s3-website-us-east-1.amazonaws.com/";
        public const string OutputPath = @"C:\Playground\ProcoreGen";

        public static HttpClient HttpClient = new HttpClient();
    }
}
