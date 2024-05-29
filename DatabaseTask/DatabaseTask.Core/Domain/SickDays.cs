using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class SickDays
    {
        [Key]
        public int SickDaysID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int EmployeeID { get; set; }
        public Employee2 Employee { get; set; }
    }

}
