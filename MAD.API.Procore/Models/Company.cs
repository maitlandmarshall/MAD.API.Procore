namespace MAD.API.Procore.Models
{
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class Company
    {
        [J("id")] public long Id { get; set; }
        [J("name")] public string Name { get; set; }
        [J("is_active")] public bool IsActive { get; set; }
    }
}
