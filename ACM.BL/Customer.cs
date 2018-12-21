﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ValidateEmail()
        {
            // -- Send an email receipt
            // If the user requested an email receipt
            // Get the customer data
            // Ensure a valid email address was provided
            // if not,
            // request an email address from the user.
        }

        public decimal CalculatePercentageOfGoalSteps(string goalSteps, string actualSteps)
        {
            // Try 1
            return (Convert.ToDecimal(actualSteps) / Convert.ToDecimal(goalSteps)) * 100;
        }
    }
}
