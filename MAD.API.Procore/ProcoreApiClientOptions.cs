using System;

namespace MAD.API.Procore
{
    public class ProcoreApiClientOptions
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public bool IsSandbox { get; set; }
    }
}