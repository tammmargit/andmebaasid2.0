using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public int ChildID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int EmployeeID { get; set; }
        public Employee2 Employee { get; set; }
    }
}
