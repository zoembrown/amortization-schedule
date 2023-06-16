using amortization_schedule_calculator.HelperClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using amortization_schedule_calculator.Models;

namespace amortization_schedule_calculator.Forms
{
    public partial class PaymentHistoryForm : Form
    {
        public PaymentHistoryForm(int loanID)
        {
            InitializeComponent();

            Loan loan = DataAccess.GetLoanByID(loanID)[0];
            PaymentHistoryDataGrid.DataSource = Amortization.loanHistory(loan);
            lblLoanInfo.Text = $"Initial Value: {loan.AmountBorrowed}\nInterest Rate: {loan.InterestRate}%\n" +
                $"Owed to: {loan.Creditor}\nDescription: {loan.Description}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
