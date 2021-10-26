using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.RFIs.Models
{
    public class CustomTextfield1
    {

        /// <summary>
        /// Project label for RFI custom text field 1
        /// </summary>
        [JsonProperty("label")] public string Label { get; set; }

        /// <summary>
        /// Value for RFI custom text field 1
        /// </summary>
        [JsonProperty("value")] public string Value { get; set; }
    }
}
