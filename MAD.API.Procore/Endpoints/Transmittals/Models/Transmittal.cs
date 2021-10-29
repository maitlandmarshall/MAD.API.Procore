using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Transmittals.Models {
	public class Transmittal {

		/// <summary>
		/// Sent method
		/// </summary>
		[JsonProperty("sent_method")]	public  string SentMethod { get ; set; }

		/// <summary>
		/// If sent_method is 'Under Separate Cover', describes the separate cover method
		/// </summary>
		[JsonProperty("via_method")]	public  string ViaMethod { get ; set; }

		/// <summary>
		/// Describes via_method 'Other' method
		/// </summary>
		[JsonProperty("via_other")]	public  string ViaOther { get ; set; }

		/// <summary>
		/// Notes/comments
		/// </summary>
		[JsonProperty("notes")]	public  string Notes { get ; set; }

		/// <summary>
		/// Actions as noted
		/// </summary>
		[JsonProperty("actions")]	public  Action Actions { get ; set; }

		[JsonProperty("cc_recipients")]	public  List<CcRecipient> CcRecipients { get ; set; }

		/// <summary>
		/// Date created
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Sent Date
		/// </summary>
		[JsonProperty("sent_date")]	public  string SentDate { get ; set; }

		/// <summary>
		/// Email sent date
		/// </summary>
		[JsonProperty("email_sent_date")]	public  string EmailSentDate { get ; set; }

		/// <summary>
		/// Due date
		/// </summary>
		[JsonProperty("due_date")]	public  string DueDate { get ; set; }

		/// <summary>
		/// Whether transmittal is private
		/// </summary>
		[JsonProperty("private")]	public  bool Private { get ; set; }

		/// <summary>
		/// If sent_method is 'Under Separate Cover', describes the separate cover method
		/// </summary>
		[JsonProperty("sent_via")]	public  string SentVia { get ; set; }

		/// <summary>
		/// Transmittal reasons (Submitted For)
		/// </summary>
		[JsonProperty("reasons")]	public  Reason Reasons { get ; set; }

		[JsonProperty("to_recipients")]	public  List<ToRecipient> ToRecipients { get ; set; }

		[JsonProperty("created_by")]	public  CreatedBy CreatedBy { get ; set; }

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Number
		/// </summary>
		[JsonProperty("number")]	public  string Number { get ; set; }

		/// <summary>
		/// Subject
		/// </summary>
		[JsonProperty("subject")]	public  string Subject { get ; set; }
	}
}
