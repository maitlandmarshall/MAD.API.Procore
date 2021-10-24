using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.DailyLogs.Models
{
    public class ListCountsOfDailyLogsRequestResult
    {

        /// <summary>
        /// The name of the log type
        /// </summary>
        [JsonProperty("module_name")] public string ModuleName { get; set; }

        /// <summary>
        /// The number of logs that match the current date and permissions filters for this module
        /// </summary>
        [JsonProperty("count")] public int? Count { get; set; }

        /// <summary>
        /// The position this module is shown at, on the web
        /// </summary>
        [JsonProperty("position")] public int? Position { get; set; }
    }
}
