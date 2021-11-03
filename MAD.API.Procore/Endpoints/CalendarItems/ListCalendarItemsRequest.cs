using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.CalendarItems.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.CalendarItems {
	public class ListCalendarItemsRequest : ProcorePaginatedRequest<IEnumerable<ScheduleCalendarItem>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/schedule/calendar_items";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// The view to use when serializing Calendar Item data.
		/// The ids_only view returns an array of Calendar Item IDs.
		/// </summary>
		[RequestParameter("view")]	public  string? View { get ; set; }

		/// <summary>
		/// Calendar Items that occur after this date
		/// </summary>
		[RequestParameter("start_date")]	public  string? StartDate { get ; set; }

		/// <summary>
		/// Calendar Items that occur before this date
		/// </summary>
		[RequestParameter("finish_date")]	public  string? FinishDate { get ; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string? UpdatedAt { get ; set; }
	}
}
