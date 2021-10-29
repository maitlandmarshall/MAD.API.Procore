using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Trades.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Trades {
	public class ShowTradeRequest : ProcoreRequest<Trade> {

		public override string Resource { get => $"/companies/{this.CompanyId}/trades/{this.Id}";}

		/// <summary>
		/// Unique identifier for the company.
		/// </summary>
		[RequestParameter("company_id")]	public  long CompanyId { get ; set; }

		/// <summary>
		/// Trade ID
		/// </summary>
		[RequestParameter("id")]	public  long Id { get ; set; }
	}
}
