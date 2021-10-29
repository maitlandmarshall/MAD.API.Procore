using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Instructions.Models {
	public class ListInstructionsOnAProjectRequestResult {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Number
		/// </summary>
		[JsonProperty("number")]	public  string Number { get ; set; }

		/// <summary>
		/// Number
		/// </summary>
		[JsonProperty("title")]	public  string Title { get ; set; }

		/// <summary>
		/// Rich Text Description
		/// </summary>
		[JsonProperty("rich_text_description")]	public  string RichTextDescription { get ; set; }

		/// <summary>
		/// Plain Text Description
		/// </summary>
		[JsonProperty("plain_text_description")]	public  string PlainTextDescription { get ; set; }

		/// <summary>
		/// Date created
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Date created
		/// </summary>
		[JsonProperty("date_received")]	public  string DateReceived { get ; set; }

		/// <summary>
		/// Date created
		/// </summary>
		[JsonProperty("date_issued")]	public  DateTimeOffset? DateIssued { get ; set; }

		/// <summary>
		/// Status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// private
		/// </summary>
		[JsonProperty("private")]	public  bool Private { get ; set; }

		[JsonProperty("schedule_impact")]	public  ScheduleImpact ScheduleImpact { get ; set; }

		[JsonProperty("cost_impact")]	public  CostImpact CostImpact { get ; set; }

		[JsonProperty("instruction_type")]	public  InstructionType InstructionType { get ; set; }

		[JsonProperty("created_by")]	public  CreatedBy CreatedBy { get ; set; }

		[JsonProperty("instruction_from")]	public  InstructionFrom InstructionFrom { get ; set; }

		/// <summary>
		/// Instruction Distribution List of Users
		/// </summary>
		[JsonProperty("distribution_members")]	public  List<DistributionMember> DistributionMembers { get ; set; }

		/// <summary>
		/// Instruction Attentions
		/// </summary>
		[JsonProperty("attentions")]	public  List<Attention> Attentions { get ; set; }

		[JsonProperty("attachments")]	public  List<Attachment> Attachments { get ; set; }

		[JsonProperty("trades")]	public  List<Trade> Trades { get ; set; }
	}
}
