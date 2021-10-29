using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Drawings.Models {
	public class DrawingRevision {

		/// <summary>
		/// Drawing date
		/// </summary>
		[JsonProperty("drawing_date")]	public  string DrawingDate { get ; set; }

		/// <summary>
		/// Drawing ID
		/// </summary>
		[JsonProperty("drawing_id")]	public  long? DrawingId { get ; set; }

		/// <summary>
		/// Amount of drawing sketches
		/// </summary>
		[JsonProperty("drawing_sketches_count")]	public  int? DrawingSketchesCount { get ; set; }

		/// <summary>
		/// Height
		/// </summary>
		[JsonProperty("height")]	public  int? Height { get ; set; }

		/// <summary>
		/// Revision ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Drawing Revision number
		/// </summary>
		[JsonProperty("number")]	public  string Number { get ; set; }

		/// <summary>
		/// PDF file size
		/// </summary>
		[JsonProperty("pdf_size")]	public  int? PdfSize { get ; set; }

		/// <summary>
		/// PDF url address
		/// </summary>
		[JsonProperty("pdf_url")]	public  string PdfUrl { get ; set; }

		/// <summary>
		/// PNG file size
		/// </summary>
		[JsonProperty("png_size")]	public  int? PngSize { get ; set; }

		/// <summary>
		/// PNG url address
		/// </summary>
		[JsonProperty("png_url")]	public  string PngUrl { get ; set; }

		/// <summary>
		/// Received date
		/// </summary>
		[JsonProperty("received_date")]	public  string ReceivedDate { get ; set; }

		/// <summary>
		/// Title
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Revision updated at
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// Width
		/// </summary>
		[JsonProperty("width")]	public  int? Width { get ; set; }

		/// <summary>
		/// Has public markup layer elements status
		/// </summary>
		[JsonProperty("has_public_markup_layer_elements")]	public  bool HasPublicMarkupLayerElements { get ; set; }

		/// <summary>
		/// Revision has drawing sketches status
		/// </summary>
		[JsonProperty("has_drawing_sketches")]	public  bool HasDrawingSketches { get ; set; }

		/// <summary>
		/// Current Drawing Revision
		/// </summary>
		[JsonProperty("current")]	public  bool Current { get ; set; }

		/// <summary>
		/// Revision floorplan status
		/// </summary>
		[JsonProperty("floorplan")]	public  bool Floorplan { get ; set; }

		/// <summary>
		/// Revision number
		/// </summary>
		[JsonProperty("revision_number")]	public  string RevisionNumber { get ; set; }

		/// <summary>
		/// Thumbnail url
		/// </summary>
		[JsonProperty("thumbnail_url")]	public  string ThumbnailUrl { get ; set; }

		/// <summary>
		/// Large thumbnail url
		/// </summary>
		[JsonProperty("large_thumbnail_url")]	public  string LargeThumbnailUrl { get ; set; }

		/// <summary>
		/// Activity stream last viewed at, currently not available
		/// </summary>
		[JsonProperty("activity_stream_last_viewed_at")]	public  string ActivityStreamLastViewedAt { get ; set; }

		/// <summary>
		/// Drawing Revision position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		/// <summary>
		/// ZIP url of Drawing Tiles
		/// </summary>
		[JsonProperty("zip_url")]	public  string ZipUrl { get ; set; }

		/// <summary>
		/// Revision of an obsolete Drawing
		/// </summary>
		[JsonProperty("obsolete")]	public  bool Obsolete { get ; set; }

		/// <summary>
		/// Drawing Set
		/// </summary>
		[JsonProperty("drawing_set")]	public  DrawingSet DrawingSet { get ; set; }

		/// <summary>
		/// Drawing Area
		/// </summary>
		[JsonProperty("drawing_area")]	public  DrawingArea DrawingArea { get ; set; }

		/// <summary>
		/// Drawing discipline
		/// </summary>
		[JsonProperty("discipline")]	public  Discipline Discipline { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }
	}
}
