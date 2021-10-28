using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Drawings.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Drawings {
	public class ListDrawingUploadsRequest : ProcorePaginatedRequest<IEnumerable<DrawingUpload>> {

		public override string Resource { get => $"/projects/{this.ProjectId}/drawing_uploads";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }
	}
}
