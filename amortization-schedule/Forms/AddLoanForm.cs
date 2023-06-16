using amortization_schedule_calculator.HelperClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amortization_schedule_calculator.Forms
{
    public partial class AddLoanForm : Form
    {
        public AddLoanForm()
        {
            InitializeComponent();
            dateTimePicker.MaxDate = DateTime.Now;
		}

        #region Event Handlers
        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            decimal initialValue = nupInitialValue.Value;
            decimal interestRate = nupInterest.Value;
            int paymentPeriod = (int)nupPaymentPeriod.Value;

            DateTime dateBorrowed = dateTimePicker.Value;

            string creditor = txtBxCreditor.Text;
            string description = txtBxDescription.Text;

            if (creditor.Equals(""))
            {
                MessageBox.Show("Creditor is a required field.");
            }
            else
            {
                DataAccess.AddNewLoan(creditor, initialValue, interestRate, dateBorrowed, description, paymentPeriod);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}
