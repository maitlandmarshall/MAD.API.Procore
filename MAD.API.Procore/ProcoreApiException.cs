using System;
using System.Net;
using System.Runtime.Serialization;

namespace MAD.API.Procore
{
    [Serializable]
    public class ProcoreApiException : Exception
    {
        public string ResponseJson { get; }
        public HttpStatusCode StatusCode { get; }

        public ProcoreApiException()
        {
        }

        public ProcoreApiException(string reasonPhrase, string responseJson, HttpStatusCode statusCode) : base($"{reasonPhrase} ({responseJson})")
        {
            this.ResponseJson = responseJson;
            this.StatusCode = statusCode;
        }
    }
}