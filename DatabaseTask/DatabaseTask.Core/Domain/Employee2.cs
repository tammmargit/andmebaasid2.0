using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Employee2
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string ContactAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string SecurityNumber { get; set; }
        public DateTime Birthday { get; set; }

        public int BranchID { get; set; }
        public Branch Branch { get; set; }

        public ICollection<Job> Jobs { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
        public ICollection<AccessPermission> AccessPermissions { get; set; }
        public ICollection<SickDays> SickDays { get; set; }
        public ICollection<HealthExamination> HealthExaminations { get; set; }
        public ICollection<Request> Requests { get; set; }
        public ICollection<Child> Children { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}