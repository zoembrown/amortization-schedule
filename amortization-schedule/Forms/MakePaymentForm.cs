using amortization_schedule_calculator.HelperClasses;
using amortization_schedule_calculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amortization_schedule_calculator.Forms
{
    public partial class MakePaymentForm : Form
    {
        private Loan loan;
        public MakePaymentForm(int loanID)
        {
            InitializeComponent();

            loan = DataAccess.GetLoanByID(loanID)[0];
            lblLoanInfo.Text = $"Initial Value: {loan.AmountBorrowed:C2}\nInterest Rate: {loan.InterestRate}%\n" +
                $"Owed to: {loan.Creditor}\n\nDescription\n{loan.Description}";
            dateTimePicker.MinDate = loan.DateBorrowed;
            dateTimePicker.MaxDate = DateTime.Now;

			dateTimePicker.CustomFormat = "MMMM yyyy";
            //dateTimePicker.ShowUpDown = true;

            nupPayment.Maximum = loan.AmountBorrowed;
		}

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            // Make sure there is not already a payment for the same month before 
            // updating the database.
            decimal paymentAmount = nupPayment.Value;
            DateTime paymentDate = dateTimePicker.Value;

            Payment payment = new Payment(loan.Id, paymentDate, paymentAmount);

            if (loan.DateBorrowed.Month == paymentDate.Month && loan.DateBorrowed.Year == paymentDate.Year)
            {
                MessageBox.Show("You cannot make a payment the same month you took out the loan.");
            }
            else if (DataAccess.GetPaymentByMonth(payment.LoanID, payment.PaymentMonth).Count != 0)
            {
                bool makePayment;

				ConfirmPaymentForm confirm = new ConfirmPaymentForm(payment.PaymentDate);
                confirm.ShowDialog();
                makePayment = confirm.MakePayment;
                confirm.Dispose();

                if (makePayment)
                {
                    DataAccess.UpdatePayment(payment);
                }
            } 
            else
            {
                DataAccess.AddPayment(payment);
            }
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
