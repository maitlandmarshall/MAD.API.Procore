using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Endpoints.Drawings.Models
{
    public class DrawingUpload
    {

        /// <summary>
        /// Drawing Upload ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [JsonProperty("project_id")] public long? ProjectId { get; set; }

        /// <summary>
        /// ID of creator
        /// </summary>
        [JsonProperty("created_by_id")] public long? CreatedById { get; set; }

        /// <summary>
        /// Drawing Upload created at
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Drawing Upload updated at
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Error email sent status
        /// </summary>
        [JsonProperty("error_email_sent")] public bool ErrorEmailSent { get; set; }

        /// <summary>
        /// Notify on success status
        /// </summary>
        [JsonProperty("notify_on_success")] public bool NotifyOnSuccess { get; set; }

        /// <summary>
        /// Deletion in progress status
        /// </summary>
        [JsonProperty("deletion_in_progress")] public bool DeletionInProgress { get; set; }

        /// <summary>
        /// Success email sent status
        /// </summary>
        [JsonProperty("success_email_sent")] public bool SuccessEmailSent { get; set; }

        /// <summary>
        /// Drawing Area ID
        /// </summary>
        [JsonProperty("drawing_area_id")] public long? DrawingAreaId { get; set; }

        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// Pre adaptive complete status
        /// </summary>
        [JsonProperty("pre_adaptive_complete")] public bool PreAdaptiveComplete { get; set; }

        /// <summary>
        /// Drawing number contains revision
        /// </summary>
        [JsonProperty("drawing_number_contains_revision")] public bool DrawingNumberContainsRevision { get; set; }

        /// <summary>
        /// Get info from filename
        /// </summary>
        [JsonProperty("get_info_from_filename")] public bool GetInfoFromFilename { get; set; }

        /// <summary>
        /// Language for OCR
        /// </summary>
        [JsonProperty("language")] public string Language { get; set; }
    }
}
