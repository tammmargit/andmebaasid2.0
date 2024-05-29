using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class AccessPermission
    {
        [Key]
        public int AccessPermissionID { get; set; }
        public string Permissions { get; set; }

        public int EmployeeID { get; set; }
        public Employee2 Employee { get; set; }
    }

}

