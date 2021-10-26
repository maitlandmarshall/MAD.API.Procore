using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.InspectionLogs.Models
{
    public class ListInspectionLogsRequestResult
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Area within the specified location
        /// </summary>
        [JsonProperty("area")] public string Area { get; set; }

        /// <summary>
        /// Additional comments
        /// </summary>
        [JsonProperty("comments")] public string Comments { get; set; }

        /// <summary>
        /// Created at
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Date of inspection
        /// </summary>
        [JsonProperty("date")] public string Date { get; set; }

        /// <summary>
        /// Estimated UTC datetime of record
        /// </summary>
        [JsonProperty("datetime")] public DateTimeOffset? Datetime { get; set; }

        /// <summary>
        /// Deleted at
        /// </summary>
        [JsonProperty("deleted_at")] public DateTimeOffset? DeletedAt { get; set; }

        /// <summary>
        /// Ending time of inspection - hour
        /// </summary>
        [JsonProperty("end_hour")] public int? EndHour { get; set; }

        /// <summary>
        /// Ending time of inspection - minute
        /// </summary>
        [JsonProperty("end_minute")] public int? EndMinute { get; set; }

        /// <summary>
        /// Type of inspector performing the inspection
        /// </summary>
        [JsonProperty("inspecting_entity")] public string InspectingEntity { get; set; }

        /// <summary>
        /// Type of inspection performed
        /// </summary>
        [JsonProperty("inspection_type")] public string InspectionType { get; set; }

        /// <summary>
        /// Name of the inspector
        /// </summary>
        [JsonProperty("inspector_name")] public string InspectorName { get; set; }

        /// <summary>
        /// Order in which this entry was recorded for the day
        /// </summary>
        [JsonProperty("position")] public int? Position { get; set; }

        /// <summary>
        /// Starting time of inspection - hour
        /// </summary>
        [JsonProperty("start_hour")] public int? StartHour { get; set; }

        /// <summary>
        /// Starting time of inspection - minute
        /// </summary>
        [JsonProperty("start_minute")] public int? StartMinute { get; set; }

        /// <summary>
        /// Updated at
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        [JsonProperty("location")] public Location Location { get; set; }

        /// <summary>
        /// :filename to be deprecated, use :name
        /// </summary>
        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }
    }
}
