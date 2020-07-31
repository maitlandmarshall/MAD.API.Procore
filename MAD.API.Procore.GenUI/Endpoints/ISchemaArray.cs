using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.GenUI.Endpoints
{
    internal interface ISchemaArray
    {
        ISchemaObject Items { get; }
    }
}
