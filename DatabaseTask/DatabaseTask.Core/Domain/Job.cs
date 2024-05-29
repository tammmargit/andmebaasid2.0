using System;
using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Job
    {
        [Key]
        public int JobID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int EmployeeID { get; set; }
        public Employee2 Employee { get; set; }
    }
}