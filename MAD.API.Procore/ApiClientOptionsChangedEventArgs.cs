using System;

namespace MAD.API.Procore
{
    public class ApiClientOptionsChangedEventArgs : EventArgs
    {
        public ApiClientOptionsChangedEventArgs(ProcoreApiClientOptions options)
        {
            Options = options;
        }

        public ProcoreApiClientOptions Options { get; }
    }
}