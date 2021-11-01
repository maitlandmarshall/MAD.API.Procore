using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Incidents.Models {
	public class IncidentRecordBaseNormal {

		/// <summary>
		/// The record type, i.e. 'injury', 'near_miss', 'environmental', or 'property_damage'
		/// </summary>
		[JsonProperty("type")]	public  string Type { get ; set; }

		/// <summary>
		/// Date returned to work
		/// </summary>
		[JsonProperty("date_returned_to_work")]	public  string DateReturnedToWork { get ; set; }

		[JsonProperty("affected_party")]	public  Party AffectedParty { get ; set; }

		[JsonProperty("affected_person")]	public  IncidentRecordBaseNormalAffectedPerson AffectedPerson { get ; set; }

		[JsonProperty("harm_source")]	public  HarmSource HarmSource { get ; set; }

		/// <summary>
		/// Date of death
		/// </summary>
		[JsonProperty("date_of_death")]	public  string DateOfDeath { get ; set; }

		/// <summary>
		/// Filing Type
		/// </summary>
		[JsonProperty("filing_type")]	public  string FilingType { get ; set; }

		/// <summary>
		/// Represents whether the injured person was hospitalized overnight
		/// </summary>
		[JsonProperty("hospitalized_overnight")]	public  bool HospitalizedOvernight { get ; set; }

		/// <summary>
		/// Represents whether the injured person was treated in the ER
		/// </summary>
		[JsonProperty("treated_in_er")]	public  bool TreatedInEr { get ; set; }

		/// <summary>
		/// The street address of the treatment facility
		/// </summary>
		[JsonProperty("treatment_facility_address")]	public  string TreatmentFacilityAddress { get ; set; }

		/// <summary>
		/// The name of the treatment facility
		/// </summary>
		[JsonProperty("treatment_facility")]	public  string TreatmentFacility { get ; set; }

		/// <summary>
		/// The name of the treatment provider
		/// </summary>
		[JsonProperty("treatment_provider")]	public  string TreatmentProvider { get ; set; }

		/// <summary>
		/// The number of days absent from work
		/// </summary>
		[JsonProperty("work_days_absent")]	public  int? WorkDaysAbsent { get ; set; }

		/// <summary>
		/// The number of days on restricted work
		/// </summary>
		[JsonProperty("work_days_restricted")]	public  int? WorkDaysRestricted { get ; set; }

		/// <summary>
		/// The number of days transferred
		/// </summary>
		[JsonProperty("work_days_transferred")]	public  int? WorkDaysTransferred { get ; set; }

		/// <summary>
		/// Body Type displayed in Body Diagram
		/// </summary>
		[JsonProperty("body_diagram_type")]	public  string BodyDiagramType { get ; set; }

		[JsonProperty("affliction_type")]	public  AfflictionType AfflictionType { get ; set; }

		/// <summary>
		/// DEPRECATED. The body part affected by the affliction
		/// </summary>
		[JsonProperty("affected_body_part")]	public  string AffectedBodyPart { get ; set; }

		/// <summary>
		/// Array of body parts affected by the affliction
		/// </summary>
		[JsonProperty("affected_body_parts")]	public  List<string> AffectedBodyParts { get ; set; }

		/// <summary>
		/// DEPRECATED. Array of afflictions affecting the injured person. Currently this is limited to one.
		/// </summary>
		[JsonProperty("afflictions")]	public  List<IncidentAffliction> Afflictions { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }

		/// <summary>
		/// Body parts affected by the injury
		/// </summary>
		[JsonProperty("body_parts")]	public  List<BodyPart> BodyParts { get ; set; }

		/// <summary>
		/// Incident Record ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// The number of the Record
		/// </summary>
		[JsonProperty("number")]	public  int? Number { get ; set; }

		/// <summary>
		/// The Incident Number combined with the Record Number
		/// </summary>
		[JsonProperty("full_number")]	public  string FullNumber { get ; set; }

		/// <summary>
		/// The id of the Incident to which the record belongs
		/// </summary>
		[JsonProperty("incident_id")]	public  long? IncidentId { get ; set; }

		/// <summary>
		/// Indicates whether the Incident Record is recordable
		/// </summary>
		[JsonProperty("recordable")]	public  bool Recordable { get ; set; }

		/// <summary>
		/// The title of the Incident to which the record belongs
		/// </summary>
		[JsonProperty("incident_title")]	public  string IncidentTitle { get ; set; }

		/// <summary>
		/// Indicates whether the Incident to which the record belongs is private
		/// </summary>
		[JsonProperty("incident_private")]	public  bool IncidentPrivate { get ; set; }

		/// <summary>
		/// Summary combining the affliction type, body part affected, and source of harm.
		/// </summary>
		[JsonProperty("summary")]	public  string Summary { get ; set; }

		/// <summary>
		/// Description of event
		/// </summary>
		[JsonProperty("description_plain_text")]	public  string DescriptionPlainText { get ; set; }

		/// <summary>
		/// Description of event in Rich Text format
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		[JsonProperty("affected_company")]	public  IncidentRecordBaseNormalAffectedCompany AffectedCompany { get ; set; }

		/// <summary>
		/// Timestamp of creation
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Timestamp of deletion
		/// </summary>
		[JsonProperty("deleted_at")]	public  DateTimeOffset? DeletedAt { get ; set; }

		[JsonProperty("managed_equipment")]	public  IncidentRecordBaseNormalManagedEquipment ManagedEquipment { get ; set; }

		[JsonProperty("incident_created_by")]	public  IncidentRecordBaseNormalIncidentCreatedBy IncidentCreatedBy { get ; set; }

		/// <summary>
		/// Timestamp of last update
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		[JsonProperty("work_activity")]	public  WorkActivity WorkActivity { get ; set; }
	}
}
