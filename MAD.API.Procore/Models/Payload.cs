using Newtonsoft.Json;
namespace MAD.API.Procore.Models
{
    public class Payload
    {

        /// <summary>
        /// Response for an Open Ended Text Item
        /// </summary>
        [JsonProperty("text_value")] public string TextValue { get; set; }

        /// <summary>
        /// Response for an Open Ended Number Item
        /// </summary>
        [JsonProperty("number_value")] public decimal? NumberValue { get; set; }

        /// <summary>
        /// Response for an Open Ended Date Item
        /// </summary>
        [JsonProperty("date_value")] public string DateValue { get; set; }

        [JsonProperty("response_option")] public ResponseOption ResponseOption { get; set; }
    }
}
