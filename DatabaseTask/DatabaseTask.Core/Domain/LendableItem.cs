using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class LendableItem
    {
        [Key]
        public int LendableItemID { get; set; }
        public string Things { get; set; }

        public int CompanyID { get; set; }
        public Company Company { get; set; }

        public ICollection<Loan> Loans { get; set; }
    }
}
