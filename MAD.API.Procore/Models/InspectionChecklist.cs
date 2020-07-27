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

    public partial class InspectionChecklist
    {
        [J("name")] public string Name { get; set; }
        [J("template_id")] public long? TemplateId { get; set; }
        [J("response_set")] public ResponseSetModel ResponseSet { get; set; }
        [J("lists")] public List[] Lists { get; set; }

        public partial class List
        {
            [J("id")] public long Id { get; set; }
            [J("list_template_id")] public long? ListTemplateId { get; set; }
            [J("name")] public string Name { get; set; }
            [J("list_template_name")] public string ListTemplateName { get; set; }
            [J("description")] public string Description { get; set; }
            [J("distribution_members")] public ClosedBy[] DistributionMembers { get; set; }
            [J("due_at")] public DateTimeOffset? DueAt { get; set; }
            [J("number")] public long? Number { get; set; }
            [J("status")] public string Status { get; set; }
            [J("inspection_date")] public DateTimeOffset? InspectionDate { get; set; }
            [J("created_at")] public DateTimeOffset CreatedAt { get; set; }
            [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
            [J("closed_at")] public DateTimeOffset? ClosedAt { get; set; }
            [J("item_count")] public long? ItemCount { get; set; }
            [J("yes_item_count")] public long? YesItemCount { get; set; }
            [J("personal")] public bool Personal { get; set; }
            [J("item_total")] public long? ItemTotal { get; set; }
            [J("conforming_item_count")] public long? ConformingItemCount { get; set; }
            [J("deficient_item_count")] public long? DeficientItemCount { get; set; }
            [J("na_item_count")] public long? NaItemCount { get; set; }
            [J("neutral_item_count")] public long? NeutralItemCount { get; set; }
            [J("not_inspected_item_count")] public long? NotInspectedItemCount { get; set; }
            [J("drawing_ids")] public long[] DrawingIds { get; set; }
            [J("current_drawing_revision_ids")] public long[] CurrentDrawingRevisionIds { get; set; }
            [J("attachments")] public Attachment[] Attachments { get; set; }
            [J("created_by")] public ClosedBy CreatedBy { get; set; }
            [J("closed_by")] public ClosedBy ClosedBy { get; set; }
            [J("location")] public Location Location { get; set; }
            [J("specification_section")] public SpecificationSection SpecificationSection { get; set; }
            [J("signature_requests")] public SignatureRequest[] SignatureRequests { get; set; }
            [J("trade")] public Trade Trade { get; set; }
            [J("inspectors")] public ClosedBy[] Inspectors { get; set; }
            [J("responsible_contractor")] public ResponsibleContractor ResponsibleContractor { get; set; }
            [J("responsible_party")] public ClosedBy ResponsibleParty { get; set; }
        }

        public partial class Attachment
        {
            [J("id")] public long Id { get; set; }
            [J("url")] public Uri Url { get; set; }
            [J("filename")] public string Filename { get; set; }
        }

        public partial class ClosedBy
        {
            [J("id")] public long Id { get; set; }
            [J("login")] public string Login { get; set; }
            [J("name")] public string Name { get; set; }
            [J("company_name", NullValueHandling = N.Ignore)] public string CompanyName { get; set; }
        }

        public partial class Value
        {
            [J("id")] public long Id { get; set; }
            [J("label")] public string Label { get; set; }
        }

        public partial class Location
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("node_name")] public string NodeName { get; set; }
            [J("parent_id")] public long ParentId { get; set; }
            [J("created_at")] public DateTimeOffset CreatedAt { get; set; }
            [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
        }

        public partial class ResponsibleContractor
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
        }

        public partial class SignatureRequest
        {
            [J("id")] public long Id { get; set; }
            [J("signatory")] public ClosedBy Signatory { get; set; }
            [J("signature")] public Signature Signature { get; set; }
        }

        public partial class Signature
        {
            [J("id")] public long Id { get; set; }
            [J("captured_by")] public ClosedBy CapturedBy { get; set; }
            [J("captured_at")] public DateTimeOffset CapturedAt { get; set; }
            [J("attachment")] public Attachment Attachment { get; set; }
        }

        public partial class SpecificationSection
        {
            [J("id")] public long Id { get; set; }
            [J("description")] public string Description { get; set; }
            [J("section")] public string Section { get; set; }
        }

        public partial class Trade
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
            [J("active")] public bool Active { get; set; }
            [J("updated_at")] public DateTimeOffset UpdatedAt { get; set; }
        }

        public partial class ResponseSetModel
        {
            [J("conforming_response")] public string ConformingResponse { get; set; }
            [J("deficient_response")] public string DeficientResponse { get; set; }
            [J("global")] public bool Global { get; set; }
        }
    }
}
