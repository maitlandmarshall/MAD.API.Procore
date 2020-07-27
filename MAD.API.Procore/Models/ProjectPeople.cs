namespace MAD.API.Procore.Models
{
    using J = Newtonsoft.Json.JsonPropertyAttribute;

    public partial class ProjectPeople
    {
        [J("contact")] public ContactModel Contact { get; set; }
        [J("employee_id")] public string EmployeeId { get; set; }
        [J("first_name")] public string FirstName { get; set; }
        [J("id")] public long Id { get; set; }
        [J("is_employee")] public bool IsEmployee { get; set; }
        [J("last_name")] public string LastName { get; set; }
        [J("user_id")] public long? UserId { get; set; }
        [J("work_classification_id")] public long? WorkClassificationId { get; set; }

        public partial class ContactModel
        {
            [J("is_active")] public bool IsActive { get; set; }
        }
    }
}
