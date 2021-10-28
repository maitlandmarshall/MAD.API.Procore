using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.Forms.Models
{
    public class Form
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Date created
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")] public string Description { get; set; }

        /// <summary>
        /// Form Template ID
        /// </summary>
        [JsonProperty("form_template_id")] public long? FormTemplateId { get; set; }

        /// <summary>
        /// Form Template Name
        /// </summary>
        [JsonProperty("form_template_name")] public string FormTemplateName { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// private
        /// </summary>
        [JsonProperty("private")] public bool Private { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Date updated
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("fillable_pdf")] public FillablePdf FillablePdf { get; set; }

        [JsonProperty("attachments")] public List<Attachment> Attachments { get; set; }

        [JsonProperty("thumbnail_url")] public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Is Form viewable flag
        /// </summary>
        [JsonProperty("viewable")] public bool Viewable { get; set; }

        /// <summary>
        /// Viewable Document ID
        /// </summary>
        [JsonProperty("viewable_document_id")] public long? ViewableDocumentId { get; set; }

        /// <summary>
        /// Holder class
        /// </summary>
        [JsonProperty("holder_class")] public string HolderClass { get; set; }

        [JsonProperty("download_all_uuid")] public DownloadAllUuid DownloadAllUuid { get; set; }

        [JsonProperty("attachment")] public Attachment Attachment { get; set; }

        [JsonProperty("permissions")] public Permission Permissions { get; set; }
    }
}
