using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.RFIs.Models {
	public class ShowRFIRequestResultQuestion {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Date
		/// </summary>
		[JsonProperty("question_date")]	public  DateTimeOffset? QuestionDate { get ; set; }

		/// <summary>
		/// Plain text body
		/// </summary>
		[JsonProperty("plain_text_body")]	public  string PlainTextBody { get ; set; }

		/// <summary>
		/// Rich text body
		/// </summary>
		[JsonProperty("rich_text_body")]	public  string RichTextBody { get ; set; }

		/// <summary>
		/// Creator name
		/// </summary>
		[JsonProperty("created_by")]	public  string CreatedBy { get ; set; }

		/// <summary>
		/// Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<ShowRFIRequestResultQuestionAttachment> Attachments { get ; set; }

		/// <summary>
		/// Answers
		/// </summary>
		[JsonProperty("answers")]	public  List<ShowRFIRequestResultQuestionAnswer> Answers { get ; set; }
	}
}
