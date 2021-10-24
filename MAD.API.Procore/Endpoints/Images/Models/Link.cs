using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Images.Models
{
    public class Link
    {

        /// <summary>
        /// A link back to the current resource
        /// </summary>
        [JsonProperty("self")] public string Self { get; set; }

        /// <summary>
        /// A link to the update endpoint for the resource
        /// </summary>
        [JsonProperty("update")] public string Update { get; set; }

        /// <summary>
        /// A link to the delete endpoint for the resource
        /// </summary>
        [JsonProperty("delete")] public string Delete { get; set; }

        /// <summary>
        /// A link to the permanent delete endpoint for the resource
        /// </summary>
        [JsonProperty("permanentlyDelete")] public string PermanentlyDelete { get; set; }

        /// <summary>
        /// A link to the retrive endpoint for the resource
        /// </summary>
        [JsonProperty("retrieve")] public string Retrieve { get; set; }
    }
}
