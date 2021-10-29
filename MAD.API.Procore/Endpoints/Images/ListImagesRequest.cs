using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using MAD.API.Procore.Endpoints.Images.Models;
using MAD.API.Procore;
namespace MAD.API.Procore.Endpoints.Images {
	public class ListImagesRequest : ProcorePaginatedRequest<IEnumerable<Image>> {

		public override string Resource { get => $"/images";}

		/// <summary>
		/// Unique identifier for the project.
		/// </summary>
		[RequestParameter("project_id")]	public  long ProjectId { get ; set; }

		/// <summary>
		/// Optional. ID of the image category to filter the images by.
		/// </summary>
		[RequestParameter("image_category_id")]	public  long? ImageCategoryId { get ; set; }

		/// <summary>
		/// Date of Photos added to the Daily Log in the format "YYYY-MM-DD", or a range of dates in the format "YYYY-MM-DD...YYYY-MM-DD".
		/// </summary>
		[RequestParameter("filters[log_date]")]	public  string LogDate { get ; set; }

		/// <summary>
		/// If true, returns only item(s) with a `private` status.
		/// </summary>
		[RequestParameter("filters[private]")]	public  bool? Private { get ; set; }

		/// <summary>
		/// If true, returns only item(s) with a `starred` status.
		/// </summary>
		[RequestParameter("filters[starred]")]	public  bool? Starred { get ; set; }

		/// <summary>
		/// Location ID. Returns item(s) with the specified Location ID or a range of Location IDs.
		/// </summary>
		[RequestParameter("filters[location_id]")]	public  int[] LocationId { get ; set; }

		/// <summary>
		/// Use together with `filters[location_id]`
		/// 
		/// </summary>
		[RequestParameter("filters[include_sublocations]")]	public  bool? IncludeSublocations { get ; set; }

		/// <summary>
		/// Array of Trade IDs. Returns item(s) with the specified Trade IDs.
		/// </summary>
		[RequestParameter("filters[trade_ids]")]	public  int[] TradeIds { get ; set; }

		/// <summary>
		/// Return item(s) containing search query
		/// </summary>
		[RequestParameter("filters[query]")]	public  string Query { get ; set; }

		/// <summary>
		/// Return item(s) created within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[created_at]")]	public  string CreatedAt { get ; set; }

		/// <summary>
		/// Return item(s) last updated within the specified ISO 8601 datetime range.
		/// </summary>
		[RequestParameter("filters[updated_at]")]	public  string UpdatedAt { get ; set; }

		/// <summary>
		/// Return item(s) with the specified IDs.
		/// </summary>
		[RequestParameter("filters[id]")]	public  int[] Id { get ; set; }

		/// <summary>
		/// Field to sort by. If the field is passed with a - (EX: -created_at) it is sorted in reverse order
		/// </summary>
		[RequestParameter("sort")]	public  string Sort { get ; set; }

		/// <summary>
		/// The data set that should be returned from the serializer.
		/// The normal view includes default fields, plus links, comments_count, trades.
		/// The android view includes default fields, plus trades, comments.
		/// The mobile view include default fields, plus log_date, trades, comments.
		/// The mobile_feed view includes default fields, plus comments.
		/// The prostore_file view includes default fields, plus images.
		/// The ids_only view does not include default fields, response returns strictly an array of image ids.
		/// Default view is normal.
		/// </summary>
		[RequestParameter("serializer_view")]	public  string SerializerView { get ; set; }
	}
}
