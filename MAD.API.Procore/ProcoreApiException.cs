using System;
using System.Runtime.Serialization;

namespace MAD.API.Procore
{
    [Serializable]
    public class ProcoreApiException : Exception
    {
        public string ResponseJson { get; }

        public ProcoreApiException()
        {
        }

        public ProcoreApiException(string reasonPhrase, string responseJson) : base(reasonPhrase)
        {
            this.ResponseJson = responseJson;
        }
    }
}