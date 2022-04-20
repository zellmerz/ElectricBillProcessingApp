using System;

namespace Customers
{
    public class Customer

    /// <summary>
    /// represents a customer
    /// Author: Joshua
    /// When: Jan 2022
    /// </summary>

    {
        // constants for calculating bill
        const decimal PRICE = 0.07m;
        const decimal ADMIN = 12;

        //private data
        private int id;
        private string fName;
        private string lName;
        private decimal kwh;
        public decimal bill;
        public decimal charge;

        // constructor
        public Customer(int n, string f, string l, decimal k, decimal b)
        {
            id = n;
            fName = f;
            lName = l;
            kwh = k;
            bill = b;        
        }

        // public methods
        /// <summary>
        /// Calculates charges and applies to customer's bill
        /// Author: Joshua
        /// When: Jan 2021
        /// </summary>
        /// <param name="kwh">amount of kWh to be charged</param>
        /// <returns>returns false if not charged, true if successful</returns>
        public virtual bool CalculateBill(decimal kwh)
        {
            bool success = true;
            if (kwh < 0)
                success = false;
            else
            {
                charge = (kwh * PRICE) + ADMIN;
                bill = charge;
            }
            return success;
        }

        /// <summary>
        /// Calculates charges and returns a decimal for stat tracking
        /// Author: Joshua
        /// When: Jan 2021
        /// </summary>
        /// <returns>Charges as decimal amount to be used for tracking stats</returns>
        public virtual decimal CalculateCharges()
        {
            return kwh * PRICE + ADMIN;
        }

        // simple override to easily display stored customer data 
        public override string ToString()
        {
            return $"{id}. {fName} {lName}, {kwh}kWH. Bill:{bill.ToString()}";
        }
        
        
    }
}
