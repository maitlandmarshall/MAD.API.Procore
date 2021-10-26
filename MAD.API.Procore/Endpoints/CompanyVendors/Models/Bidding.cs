using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.CompanyVendors.Models
{
    public class Bidding
    {

        [JsonProperty("affirmative_action")] public bool AffirmativeAction { get; set; }

        [JsonProperty("small_business")] public bool SmallBusiness { get; set; }

        [JsonProperty("african_american_business")] public bool AfricanAmericanBusiness { get; set; }

        [JsonProperty("hispanic_business")] public bool HispanicBusiness { get; set; }

        [JsonProperty("womens_business")] public bool WomensBusiness { get; set; }

        [JsonProperty("historically_underutilized_business")] public bool HistoricallyUnderutilizedBusiness { get; set; }

        [JsonProperty("sdvo_business")] public bool SdvoBusiness { get; set; }

        [JsonProperty("certified_business_enterprise")] public bool CertifiedBusinessEnterprise { get; set; }

        [JsonProperty("asian_american_business")] public bool AsianAmericanBusiness { get; set; }

        [JsonProperty("native_american_business")] public bool NativeAmericanBusiness { get; set; }

        [JsonProperty("disadvantaged_business")] public bool DisadvantagedBusiness { get; set; }

        [JsonProperty("minority_business_enterprise")] public bool MinorityBusinessEnterprise { get; set; }

        [JsonProperty("eight_a_business")] public bool EightABusiness { get; set; }
    }
}
