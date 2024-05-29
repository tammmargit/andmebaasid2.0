using System;
using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Vacation
    {
        [Key]
        public int VacationID { get; set; }
        public string Type { get; set; }

        public int EmployeeID { get; set; }
        public Employee2 Employee { get; set; }
    }
}