using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPro2.Models
{
    public class Household
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> User { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<BudgetItem> BudgetItems { get; set; }


    }
}