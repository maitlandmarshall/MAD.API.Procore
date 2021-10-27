using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Incidents.Models {
	public class WitnessStatement {

		/// <summary>
		/// Witness Statement ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Incident ID
		/// </summary>
		[JsonProperty("incident_id")]	public  long? IncidentId { get ; set; }

		[JsonProperty("attachments")]	public  List<IncidentAttachment> Attachments { get ; set; }

		/// <summary>
		/// The account of the event by the witness in rich text form.
		/// </summary>
		[JsonProperty("statement")]	public  string Statement { get ; set; }

		/// <summary>
		/// The account of the event by the witness in plain text form.
		/// </summary>
		[JsonProperty("statement_plain_text")]	public  string StatementPlainText { get ; set; }

		/// <summary>
		/// Date that the Witness Statement was received.
		/// </summary>
		[JsonProperty("date_received")]	public  string DateReceived { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Timestamp of deletion
		/// </summary>
		[JsonProperty("deleted_at")]	public  DateTimeOffset? DeletedAt { get ; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		[JsonProperty("witness")]	public  Witnes Witness { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }
	}
}
