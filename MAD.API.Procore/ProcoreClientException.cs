using System;
using System.Runtime.Serialization;

namespace MAD.API.Procore
{
    [Serializable]
    public class ProcoreClientException : Exception
    {
        public ProcoreClientException()
        {
        }

        public ProcoreClientException(string message) : base(message)
        {
        }

        public ProcoreClientException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProcoreClientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}