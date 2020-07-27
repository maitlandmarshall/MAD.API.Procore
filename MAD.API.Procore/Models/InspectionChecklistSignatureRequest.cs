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

    public partial class InspectionChecklistSignatureRequest
    {
        [J("id")] public long Id { get; set; }
        [J("signatory")] public SignatoryModel Signatory { get; set; }
        [J("signature")] public SignatureModel Signature { get; set; }

        public partial class SignatoryModel
        {
            [J("id")] public long Id { get; set; }
            [J("login")] public string Login { get; set; }
            [J("name")] public string Name { get; set; }
            [J("company_name")] public string CompanyName { get; set; }
        }

        public partial class SignatureModel
        {
            [J("id")] public long Id { get; set; }
            [J("captured_by")] public SignatoryModel CapturedBy { get; set; }
            [J("captured_at")] public DateTimeOffset? CapturedAt { get; set; }
            [J("attachment")] public AttachmentModel Attachment { get; set; }
        }

        public partial class AttachmentModel
        {
            [J("id")] public long Id { get; set; }
            [J("url")] public Uri Url { get; set; }
            [J("filename")] public string Filename { get; set; }
        }
    }

    
}
