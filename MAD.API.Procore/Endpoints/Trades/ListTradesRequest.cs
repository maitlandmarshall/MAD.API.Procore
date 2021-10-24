using MAD.API.Procore.Endpoints.Trades.Models;
using MAD.API.Procore.Requests;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Trades
{
    public class ListTradesRequest : ProcoreRequest<IEnumerable<Trade>>
    {

        public override string Resource { get => $"/companies/{CompanyId}/trades"; }

        /// <summary>
        /// Unique identifier for the company.
        /// </summary>
        [RequestParameter("company_id")] public long? CompanyId { get; set; }

        /// <summary>
        /// Return item(s) last updated within the specified ISO 8601 datetime range.
        /// </summary>
        [RequestParameter("filters[updated_at]")] public string UpdatedAt { get; set; }

        /// <summary>
        /// Limit results to available trades
        /// </summary>
        [RequestParameter("filters[active]")] public bool Active { get; set; }
    }
}
