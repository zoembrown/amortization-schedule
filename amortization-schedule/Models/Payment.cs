using amortization_schedule_calculator.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amortization_schedule_calculator.Models
{
    public class Payment
    {
        public int LoanID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public int PaymentMonth { get; set; }

        // Derived helper functions
        private DateTime getLoanDate() 
        {
            Loan loan = DataAccess.GetLoanByID(LoanID)[0];
            return loan.DateBorrowed;
        }


		#region Constructors
		// The constructor that automatically calculates the correct number for the payment.
		public Payment(int loanID, DateTime paymentDate, decimal paymentAmount) 
        {
            this.LoanID = loanID;
            this.PaymentDate = paymentDate;
            this.PaymentAmount = paymentAmount;

            DateTime loanDate = getLoanDate();
            
            this.PaymentMonth = ((PaymentDate.Year - loanDate.Year) * 12) + PaymentDate.Month - loanDate.Month;
		}

        // Dapper needs a default constructor without parameters to convert data from the database to an object
        public Payment() { }
		#endregion Constructors
	}
}
