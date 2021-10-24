using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.ProjectDates.Models
{
    public class ScheduleDate
    {
        /// <summary>
        /// Substantial completion date
        /// </summary>
        [JsonProperty("substantial_completion_date")] public string SubstantialCompletionDate { get; set; }

        /// <summary>
        /// Finish variance
        /// </summary>
        [JsonProperty("finish_variance")] public string FinishVariance { get; set; }

        /// <summary>
        /// Percentage complete
        /// </summary>
        [JsonProperty("percentage_complete")] public int? PercentageComplete { get; set; }
    }
}
