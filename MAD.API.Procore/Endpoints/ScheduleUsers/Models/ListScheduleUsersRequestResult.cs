using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.ScheduleUsers.Models
{
    public class ListScheduleUsersRequestResult
    {

        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// The email address of the user that is used to log in.
        /// </summary>
        [JsonProperty("login")] public string Login { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// User's contact is active in company
        /// </summary>
        [JsonProperty("is_active")] public bool IsActive { get; set; }

        /// <summary>
        /// User's contact id in company
        /// </summary>
        [JsonProperty("contact_id")] public long? ContactId { get; set; }

        /// <summary>
        /// Vendor name
        /// </summary>
        [JsonProperty("company_name")] public string CompanyName { get; set; }
    }
}
