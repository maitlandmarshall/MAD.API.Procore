namespace MAD.API.Procore.Models
{
    using System;
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class InspectionType
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("created_at")] public DateTimeOffset CreatedAt { get; set; }
        [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
    }
}
