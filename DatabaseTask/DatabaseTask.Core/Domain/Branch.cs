using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }
        public string Address { get; set; }
        public string ContactAddress { get; set; }
        public string Telephone { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Email { get; set; }
        public string RegistryCode { get; set; }

        public int CompanyID { get; set; }
        public Company Company { get; set; }

        public ICollection<Employee2> Employees { get; set; }
    }

}

