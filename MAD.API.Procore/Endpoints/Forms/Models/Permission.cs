using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Forms.Models
{
    public class Permission
    {

        /// <summary>
        /// Can Edit permission
        /// </summary>
        [JsonProperty("can_edit")] public bool CanEdit { get; set; }
    }
}
