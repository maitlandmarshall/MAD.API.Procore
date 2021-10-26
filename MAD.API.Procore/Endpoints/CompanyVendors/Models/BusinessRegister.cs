using Newtonsoft.Json;
using System;
namespace MAD.API.Procore.Endpoints.CompanyVendors.Models
{
    public class BusinessRegister
    {

        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// business register type (ABN, EIN)
        /// </summary>
        [JsonProperty("type")] public string Type { get; set; }

        /// <summary>
        /// Identification code
        /// </summary>
        [JsonProperty("identifier")] public string Identifier { get; set; }

        /// <summary>
        /// Verified at
        /// </summary>
        [JsonProperty("verified_at")] public DateTimeOffset? VerifiedAt { get; set; }

        /// <summary>
        /// Verification status (active, cancelled, does_not_exist)
        /// </summary>
        [JsonProperty("verification_status")] public string VerificationStatus { get; set; }
    }
}
