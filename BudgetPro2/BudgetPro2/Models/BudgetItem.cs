using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgetPro2.Models
{
    public class BudgetItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public decimal Amount { get; set; }

        public bool BudType { get; set; }

        public virtual BudgetCategory BudgetCategory { get; set; }
        public virtual Household Household { get; set; }

    }
}