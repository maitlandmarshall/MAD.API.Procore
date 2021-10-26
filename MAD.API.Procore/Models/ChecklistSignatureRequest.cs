using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class ChecklistSignatureRequest
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("signatory")] public Signatory Signatory { get; set; }

        [JsonProperty("signature")] public ChecklistSignature Signature { get; set; }
    }
}
