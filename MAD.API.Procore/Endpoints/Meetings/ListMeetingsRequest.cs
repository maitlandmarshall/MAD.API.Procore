using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Meetings.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Meetings {
	public class ListMeetingsRequest : ProcorePaginatedRequest<IEnumerable<Meeting>> {

		public override string Resource { get => $"/meetings";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// The data set that should be returned from the serializer.
		/// The normal view includes default fields.
		/// The extended view includes the default fields plus Meeting Template fields.
		/// Default view is normal.
		/// </summary>
		[RequestParameter("serializer_view")]	public  string? SerializerView { get ; set; }
	}
}
