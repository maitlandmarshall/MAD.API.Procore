namespace MAD.API.Procore.Models
{
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class InspectionPossibleInspector
    {
        [J("people")] public Person[] People { get; set; }

        public partial class Person
        {
            [J("id")] public long Id { get; set; }
            [J("login")] public string Login { get; set; }
            [J("name")] public string Name { get; set; }
            [J("company")] public Company Company { get; set; }
        }

        public partial class Company
        {
            [J("id")] public long Id { get; set; }
            [J("name")] public string Name { get; set; }
        }
    }
}
