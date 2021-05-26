using System;

namespace MAD.API.Procore
{
    public class ProcoreApiClientOptions
    {
        internal string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public bool IsSandbox { get; set; }
    }
}