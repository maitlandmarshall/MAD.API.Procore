using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.BIMModels.Models
{
    public class CurrentRevision
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// ID of the associated BIM File
        /// </summary>
        [JsonProperty("bim_file_id")] public long? BimFileId { get; set; }

        /// <summary>
        /// ID of the associated BIM Model
        /// </summary>
        [JsonProperty("bim_model_id")] public long? BimModelId { get; set; }

        /// <summary>
        /// ID of the associated geometry file bundle
        /// </summary>
        [JsonProperty("geometry_file_bundle_id")] public long? GeometryFileBundleId { get; set; }

        /// <summary>
        /// Suitability of the revision
        /// </summary>
        [JsonProperty("suitability")] public string Suitability { get; set; }

        /// <summary>
        /// Status of the revision
        /// </summary>
        [JsonProperty("publish_status")] public string PublishStatus { get; set; }

        /// <summary>
        /// The sequential revision count
        /// </summary>
        [JsonProperty("revision")] public int? Revision { get; set; }

        /// <summary>
        /// Name of application publishing the model revision
        /// </summary>
        [JsonProperty("publisher_name")] public string PublisherName { get; set; }

        /// <summary>
        /// Version of application publishing the model revision
        /// </summary>
        [JsonProperty("publisher_version")] public string PublisherVersion { get; set; }

        /// <summary>
        /// 3D Coordinate Point
        /// </summary>
        [JsonProperty("min_boundary")] public MinBoundary MinBoundary { get; set; }

        /// <summary>
        /// 3D Coordinate Point
        /// </summary>
        [JsonProperty("max_boundary")] public MaxBoundary MaxBoundary { get; set; }

        /// <summary>
        /// 3D Coordinate Point
        /// </summary>
        [JsonProperty("rotation")] public Rotation Rotation { get; set; }

        /// <summary>
        /// An array of viewpoints
        /// </summary>
        [JsonProperty("viewpoints")] public List<Viewpoint> Viewpoints { get; set; }

        [JsonProperty("created_by")] public CreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        [JsonProperty("created_at")] public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Updated date
        /// </summary>
        [JsonProperty("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// BIM Gridline stores the gridline details exported from modeling software like Revit
        /// </summary>
        [JsonProperty("bim_gridline")] public BimGridline BimGridline { get; set; }

        [JsonProperty("published_model")] public PublishedModel PublishedModel { get; set; }

        [JsonProperty("object_definition")] public ObjectDefinition ObjectDefinition { get; set; }
    }
}
