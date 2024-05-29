using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Loan
    {
        [Key]
        public int LoanID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HowMany { get; set; }
        public string State { get; set; }

        public int EmployeeID { get; set; }
        public Employee2 Employee { get; set; }

        public int LendableItemID { get; set; }
        public LendableItem LendableItem { get; set; }
    }
}
