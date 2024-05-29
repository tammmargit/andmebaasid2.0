using DatabaseTask.Core.Domain;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{

    public class HealthExamination
    {
        [Key]
        public int HealthExaminationID { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }

        public int EmployeeID { get; set; }
        public Employee2 Employee { get; set; }
    }
}