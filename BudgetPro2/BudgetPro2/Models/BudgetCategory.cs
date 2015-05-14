using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPro2.Models
{
    public class BudgetCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BudgetItem> BudgetItems { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }

    }
}