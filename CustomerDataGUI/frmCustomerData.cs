using Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomerDataGUI
{
    public partial class frmCustomerData : Form
    {
        // set constants
        const decimal PRICE = 0.07m;
        const decimal ADMIN = 12;
        // Form level list to track and display customer data
        List<Customer> customers = new List<Customer>();

        // set variables for additional data we want calculated and tracked
        decimal avgBill = 0;
        decimal totalBill = 0;
        decimal totalKWH = 0;
        int totalCust = 0;
        int id = 1;
        
        public frmCustomerData()
        {
            InitializeComponent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            // adding needed variables
            string fName;
            string lName;
            decimal kwh;
            decimal bill;
            Customer cust;


            // verify valid data is entered
            // if data is valid, create new customer

            if (validator.IsPresent(txtFName) &&
                validator.IsPresent(txtLName) &&
                validator.IsPresent(txtKWH) &&
                validator.IsNonNegativeDecimal(txtKWH)
                )
            {
                
                fName = txtFName.Text;
                lName = txtLName.Text;
                totalCust += 1;
                kwh = Convert.ToDecimal(txtKWH.Text);
                bill = 0;
                cust = new Customer(id, fName, lName, kwh, bill);
                // update bill in the new Customer created
                cust.CalculateBill(kwh);
                
               
            }
            else  // failed validation
                return;

            // add to list and display in box
            customers.Add(cust);
            DisplayCustomers();

            // update needed variables
            totalCust = customers.Count();
            totalKWH += kwh;
            totalBill += cust.CalculateCharges();

            // update and display stats (# of customers, TotalKWH, average bill)
            lblCustProc.Text = totalCust.ToString();
            lblKWHBilled.Text = totalKWH.ToString();
            Convert.ToDecimal(totalCust);
            avgBill = CalculateAvgBill();
            lblAVGBill.Text = avgBill.ToString("c");
            id += 1;

            // reset data entry

            ResetControls();
        }

        // reset form data
        private void ResetControls()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtKWH.Text = "";
            txtFName.Focus();
        }

        // calculates pay and adds to list ( calls ToString() from cust ojbect )
        private void DisplayCustomers()
        {
            lstCustData.Items.Clear();
            foreach (Customer cust in customers)
            {
                
                lstCustData.Items.Add($"{cust}"); 
            }

        }

        // terminate application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // calculate average bill for stat tracking
        public decimal CalculateAvgBill()
        {
            return totalBill / totalCust;
            
        }

    }
}
