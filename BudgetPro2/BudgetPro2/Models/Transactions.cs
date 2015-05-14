using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgetPro2.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Type { get; set; }//check if needed , type exists in budgetitem
        public DateTimeOffset Date { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public decimal Amount { get; set; }

        public decimal ReconciledAmount { get; set; }



        public virtual Account Account { get; set; }
        public virtual BudgetCategory BudgetCategory { get; set; }
        //public virtual Household Household { get; set; }

    }
}