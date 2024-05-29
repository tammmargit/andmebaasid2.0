using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Company
        {
            [Key]
            public int CompanyID { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public string Industry { get; set; }
            public string Email { get; set; }
            public string ContactAddress { get; set; }
            public string RegistryCode { get; set; }
            public int NumberOfEmployees { get; set; }

            public ICollection<Branch> Branches { get; set; }
            public ICollection<LendableItem> LendableItems { get; set; }
        }
    }

