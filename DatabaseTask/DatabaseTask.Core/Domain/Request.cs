using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Request
    {
        [Key]
        public int RequestID { get; set; }
        public string RequestType { get; set; }
        public DateTime RequestDate { get; set; }

        public int EmployeeID { get; set; }
        public Employee2 Employee { get; set; }
    }

}
