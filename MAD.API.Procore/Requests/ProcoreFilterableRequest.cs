using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Procore.Requests
{
    public abstract class ProcoreFilterableRequest<TModel> : ProcoreRequest<TModel>
    {
        [RequestParameter("filters[updated_at]")]
        public DateTime? UpdatedAt { get; }
    }
}
