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
	public partial class LoanSelectForm : Form
	{
		private int selectedLoanID = -1;
		public LoanSelectForm()
		{
			InitializeComponent();

			List<Loan> loans = DataAccess.GetAllLoans();
			loanDataGrid.DataSource = loans;
		}
		
		public int SelectedLoanID
		{
			get 
			{
				return selectedLoanID;
			}
		}
		private void btnSelectLoan_Click(object sender, EventArgs e)
		{
			selectedLoanID = getSelectedLoanID();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		#region Helper
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
		#endregion Helper

	}
}
