using Microsoft.VisualStudio.TestTools.UnitTesting;
using Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Tests
{
    [TestClass()]
    public class CustomerTests
    {

        // ensure a customer is charged properly and account is updated with +kwh
        [TestMethod()]
        public void CalculateBillPositiveTest()
        {
            // arrange
            Customer cust = new Customer(1, "Fred", "Savage", 100, 0);
            decimal kwh = 100;
            decimal expectedCharge = 19;
            decimal actualCharge;
            bool expectedResult = true;
            bool actualResult;

            // act
            actualResult = cust.CalculateBill(kwh);
            actualCharge = cust.bill;

            // assert
            Assert.AreEqual(expectedCharge, actualCharge);
            Assert.AreEqual(expectedResult, actualResult);
        }

        // customer cannot use -kwh, data must be re-entered before continuing
        [TestMethod()]
        public void CalculateBillNegativeTest()
        {
            // arrange
            Customer cust = new Customer(1, "Fred", "Savage", 100, 0);
            decimal kwh = -100;
            decimal expectedCharge = 0;
            decimal actualCharge;
            bool expectedResult = false;
            bool actualResult;

            // act
            actualResult = cust.CalculateBill(kwh);
            actualCharge = cust.bill;

            // assert
            Assert.AreEqual(expectedCharge, actualCharge);
            Assert.AreEqual(expectedResult, actualResult);
        }


        // even if customer doesn't use any kWh, they will still be charged an admin fee
        [TestMethod()]
        public void CalculateBillZeroTest()
        {
            // arrange
            Customer cust = new Customer(1, "Fred", "Savage", 100, 0);
            decimal kwh = 0;
            decimal expectedCharge = 12;
            decimal actualCharge;
            bool expectedResult = true;
            bool actualResult;

            // act
            actualResult = cust.CalculateBill(kwh);
            actualCharge = cust.bill;

            // assert
            Assert.AreEqual(expectedCharge, actualCharge);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}