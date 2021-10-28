using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Images.Models {
	public class Image {

		/// <summary>
		/// Image ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Image url
		/// </summary>
		[JsonProperty("url")]	public  string Url { get ; set; }

		/// <summary>
		/// Image size
		/// </summary>
		[JsonProperty("size")]	public  int? Size { get ; set; }

		/// <summary>
		/// Image file name
		/// </summary>
		[JsonProperty("filename")]	public  string Filename { get ; set; }

		/// <summary>
		/// Image description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Image thumbnail url
		/// </summary>
		[JsonProperty("thumbnail_url")]	public  string ThumbnailUrl { get ; set; }

		/// <summary>
		/// Image taken at
		/// </summary>
		[JsonProperty("taken_at")]	public  DateTimeOffset? TakenAt { get ; set; }

		/// <summary>
		/// Image created at
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Image updated at
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		[JsonProperty("location")]	public  Location Location { get ; set; }

		/// <summary>
		/// Image Category Name
		/// </summary>
		[JsonProperty("image_category_name")]	public  string ImageCategoryName { get ; set; }

		/// <summary>
		/// Image Category ID
		/// </summary>
		[JsonProperty("image_category_id")]	public  long? ImageCategoryId { get ; set; }

		/// <summary>
		/// Image permanent deletion status
		/// </summary>
		[JsonProperty("permanently_deleted")]	public  bool PermanentlyDeleted { get ; set; }

		/// <summary>
		/// Image private status
		/// </summary>
		[JsonProperty("private")]	public  bool Private { get ; set; }

		/// <summary>
		/// Image starred status
		/// </summary>
		[JsonProperty("starred")]	public  bool Starred { get ; set; }

		/// <summary>
		/// Image width
		/// </summary>
		[JsonProperty("width")]	public  int? Width { get ; set; }

		/// <summary>
		/// Image height
		/// </summary>
		[JsonProperty("height")]	public  int? Height { get ; set; }

		[JsonProperty("uploader")]	public  Uploader Uploader { get ; set; }

		[JsonProperty("links")]	public  Link Links { get ; set; }

		[JsonProperty("trades")]	public  List<Trade> Trades { get ; set; }

		/// <summary>
		/// the number of comments on this image
		/// </summary>
		[JsonProperty("comments_count")]	public  int? CommentsCount { get ; set; }
	}
}
