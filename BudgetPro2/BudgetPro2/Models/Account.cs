using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgetPro2.Models
{
    public class Account
    {
        //public Account()
        //{
        //    this.Transactions = new HashSet<Transactions>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }

        public int HouseholdId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public decimal Balance { get; set; }


        public virtual Household Household { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }

			

    }

}