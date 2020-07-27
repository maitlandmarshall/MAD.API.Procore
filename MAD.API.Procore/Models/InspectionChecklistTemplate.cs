namespace MAD.API.Procore.Models
{
    using System;
    using J = Newtonsoft.Json.JsonPropertyAttribute;
    using N = Newtonsoft.Json.NullValueHandling;

    public partial class InspectionChecklistTemplate
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("description")] public string Description { get; set; }
        [J("inspection_type")] public InspectionTypeModel InspectionType { get; set; }
        [J("trade")] public InspectionTypeModel Trade { get; set; }
        [J("created_at")] public DateTimeOffset CreatedAt { get; set; }
        [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }

        public partial class InspectionTypeModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("created_at", NullValueHandling = N.Ignore)] public DateTimeOffset? CreatedAt { get; set; }
            [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
            [J("active", NullValueHandling = N.Ignore)] public bool? Active { get; set; }
        }
    }
}
