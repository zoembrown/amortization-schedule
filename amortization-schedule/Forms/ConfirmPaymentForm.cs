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
	public partial class ConfirmPaymentForm : Form
	{
		private DateTime paymentDate;
		private bool makePayment;
		public ConfirmPaymentForm(DateTime paymentDate)
		{
			InitializeComponent();

			this.paymentDate = paymentDate;

			lblMainText.Text = $"You already made a payment in {paymentDate.ToString("MMMM yyyy")}\n" +
				$"Do you mean to replace the existing payment?";
		}

		public bool MakePayment 
		{
			get 
			{
				return makePayment;
			}
		}

		private void btnCancelPayment_Click(object sender, EventArgs e)
		{
			makePayment = false;
			this.Close();
		}

		private void btnMakePayment_Click(object sender, EventArgs e)
		{
			makePayment= true;
			this.Close();
		}
	}
}
