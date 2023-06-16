using amortization_schedule_calculator.Models;
using amortization_schedule_calculator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using amortization_schedule_calculator.HelperClasses;
using amortization_schedule_calculator.App_Data;

namespace amortization_schedule_calculator.Forms
{
    public partial class MainForm : Form
    {
        private Loan selectedLoan;

        public MainForm()
        {
            InitializeComponent();
        }

		#region Event Handlers
		private void MainForm_Load(object sender, EventArgs e)
        {
            populateLoanGrid();
        }

        #region Edit Loan List Event Handlers
        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            AddLoanForm addForm = new AddLoanForm();
            addForm.ShowDialog();
            populateLoanGrid();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            int loanID = getSelectedLoanID();
            // Make sure a row is selected.
            if (loanID == -1)
            {
                MessageBox.Show("You have no loans to make payments on.");
            }
            else
            {
                MakePaymentForm paymentForm = new MakePaymentForm(loanID);
                paymentForm.ShowDialog();
                populateLoanGrid();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            int loanID = getSelectedLoanID();
            if (loanID == -1)
            {
                MessageBox.Show("There are no loans available to view.");
            }
            else
            {
                PaymentHistoryForm history = new PaymentHistoryForm(loanID);
                history.ShowDialog();
            }
        }
        
		#endregion Edit Loan List Event Handlers

		#region Amortization Tables Event Handlers
		private void btnChooseLoan_Click(object sender, EventArgs e)
		{
            selectLoan();

            if (selectedLoan != null)
            {
                grpBxShowHistory.Visible = true;
                grpBxPaymentAmount.Visible = true;

                fillAmortizationDataGrid();
            }
		}

		private void btnCalculateTable_Click(object sender, EventArgs e)
		{
            if (selectedLoan == null)
            {
                selectLoan();
            }

            // The if statement is in case the user closes the selectLoanForm without choosing a loan.
            if (selectedLoan != null)
            {
				grpBxShowHistory.Visible = true;
				grpBxPaymentAmount.Visible = true;

                fillAmortizationDataGrid();
            }
		}

		private void chkBxMinimumPayment_CheckedChanged(object sender, EventArgs e)
		{
            nupCustomPayment.Visible = !chkBxMinimumPayment.Checked;
            lblCustomPayment.Visible = !chkBxMinimumPayment.Checked;
		}
		#endregion Amortization Tables Event Handlers

		#endregion Event Handlers


		#region Helper Methods
		private void populateLoanGrid()
        {
            loanDataGrid.DataSource = DataAccess.GetAllLoans();
        }

        private int getSelectedLoanID()
        {
            if (loanDataGrid.SelectedRows.Count == 0) 
            {
                return -1;   
            }
            else
            {            
                DataGridViewRow row = loanDataGrid.SelectedRows[0];                
                int loanID = int.Parse(row.Cells[0].Value.ToString());                
                return loanID;
                
            }
            
        }

        private void selectLoan()
        {
			LoanSelectForm loanSelect = new LoanSelectForm();
			loanSelect.ShowDialog();

			if (loanSelect.SelectedLoanID != -1)
			{
				selectedLoan = DataAccess.GetLoanByID(loanSelect.SelectedLoanID)[0];
				lblLoanInfo.Text = $"Current Balance: {selectedLoan.GetRemainingBalance():C2}\nMinimum Payment: {selectedLoan.GetMinimumPayment():C2}";
                nupCustomPayment.Minimum = selectedLoan.GetMinimumPayment();
                nupCustomPayment.Maximum = selectedLoan.GetRemainingBalance();
			}

			loanSelect.Dispose();

		} 

        private void fillAmortizationDataGrid()
        {
            bool showHistory = radBtnShowPast.Checked;
            bool makeMinimumPayment = chkBxMinimumPayment.Checked;

            if (makeMinimumPayment)
            {
                amortizationTableDataGrid.DataSource = Amortization.calculateAmortizationTable(selectedLoan, showHistory);
            }
            else
            {
                double monthlyPayment = (double)nupCustomPayment.Value;
                amortizationTableDataGrid.DataSource = Amortization.calculateAmortizationTable(selectedLoan, monthlyPayment, showHistory);
            }

			lblLoanInfo.Text = $"Current Balance: {selectedLoan.GetRemainingBalance():C2}\nMinimum Payment: {selectedLoan.GetMinimumPayment():C2}";
		}
		#endregion Helper Methods


	}
}
