using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.SpecificationSections.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.SpecificationSections {
	public class ListSpecificationSectionsRequest : ProcorePaginatedRequest<IEnumerable<ListSpecificationSectionsRequestResult>> {

		public override string Resource { get => $"/specification_sections";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")]	public  int[] Id { get ; set; }
	}
}
