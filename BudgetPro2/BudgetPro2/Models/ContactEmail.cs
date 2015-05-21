using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPro2.Models
{
    public class ContactEmail
    {
            public int ContactEmailId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

            public int HouseholdId { get; set; }
            
        
    }
}