namespace MAD.API.Procore.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using J = Newtonsoft.Json.JsonPropertyAttribute;
    using R = Newtonsoft.Json.Required;
    using N = Newtonsoft.Json.NullValueHandling;

    public partial class InspectionChecklistTemplate
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("description")] public string Description { get; set; }
        [J("company_description")] public string CompanyDescription { get; set; }
        [J("created_at")] public DateTimeOffset CreatedAt { get; set; }
        [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
        [J("inspection_type")] public InspectionTypeModel InspectionType { get; set; }
        [J("alternative_response_set_id")] public object AlternativeResponseSetId { get; set; }
        [J("response_set")] public ResponseSetModel ResponseSet { get; set; }
        [J("location")] public object Location { get; set; }
        [J("trade")] public TradeModel Trade { get; set; }
        [J("created_by")] public CreatedByModel CreatedBy { get; set; }
        [J("attachments")] public Attachment[] Attachments { get; set; }
        [J("sections")] public Section[] Sections { get; set; }

        public partial class Attachment
        {
            [J("id")] public long Id { get; set; }
            [J("url")] public Uri Url { get; set; }
            [J("filename")] public string Filename { get; set; }
        }

        public partial class CreatedByModel
        {
            [J("id")] public long Id { get; set; }
            [J("login")] public string Login { get; set; }
            [J("name")] public string Name { get; set; }
        }

        public partial class InspectionTypeModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
        }

        public partial class ResponseSetModel
        {
            [J("conforming_response")] public string ConformingResponse { get; set; }
            [J("deficient_response")] public string DeficientResponse { get; set; }
            [J("global")] public bool Global { get; set; }
        }

        public partial class Section
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("position")] public long Position { get; set; }
            [J("items")] public Item[] Items { get; set; }
        }

        public partial class Item
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("status")] public string Status { get; set; }
            [J("section_id")] public long SectionId { get; set; }
            [J("position")] public long Position { get; set; }
        }

        public partial class TradeModel
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("active")] public bool Active { get; set; }
            [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
        }
    }

   
}
