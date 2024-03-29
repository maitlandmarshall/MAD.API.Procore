using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Trades.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Trades
{
	public class ListTradesRequest : ProcorePaginatedRequest<IEnumerable<Trade>>
	{

		public override string Resource { get => $"/companies/{this.CompanyId}/trades"; }

		/// <summary>
		/// Unique identifier for the company.
		/// </summary>
		[RequestParameter("company_id")] public long CompanyId { get; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")] public string? UpdatedAt { get; set; }

		/// <summary>
		/// Limit results to available trades
		/// </summary>
		[RequestParameter("filters[active]")] public bool? Active { get; set; }
	}
}
