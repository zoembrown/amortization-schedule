using amortization_schedule_calculator.HelperClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Amortization Schedule:
 * https://www.investopedia.com/terms/a/amortization.asp#:~:text=How%20to%20Calculate%20Amortization%20of%20Loans&text=You'll%20need%20to%20divide,your%20loan%20term%20by%2012.
 * https://www.investopedia.com/terms/a/amortization_schedule.asp
 */

/*
 * The database works best with decimal values but a lot of the math works better with doubles.
 * That's why there's so many casts between the two data types in this class.
 */
namespace amortization_schedule_calculator.Models
{
    public class Loan
    {
		#region Database Fields -- Id, Creditor, AmountBorrowed, InterestRate, DateBorrowed, Description, PaymentPeriod

		public int Id { get; set; }
        public string Creditor { get; set; }
        public decimal AmountBorrowed { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime DateBorrowed { get; set; }
        public string Description { get; set; }
        // The length of the loan in years
        public int PaymentPeriod { get; set; }

		#endregion Database Fields


		#region Calculated Fields -- LastPaymentDate, RemainingPaymentPeriods, RemainingBalance, MinimumPayment
		// The date that the last payment is due.
		public DateTime GetLastPaymentDate()
        {
            return DateBorrowed.AddYears(PaymentPeriod);
        }

		// Find the number of payments left to make.
		// This is the same as the number of months between the current date and
		// the day the last payment is due.
		public int GetRemainingPaymentPeriods()
		{
			return ((GetLastPaymentDate().Year - DateTime.Now.Year) * 12) + GetLastPaymentDate().Month - DateTime.Now.Month;
		}

		// The number for a payment made in the current month.
		public int GetCurrentPaymentNumber()
		{
			return ((DateTime.Now.Year - DateBorrowed.Year) * 12) + DateTime.Now.Month - DateBorrowed.Month;
		}

		// The balance left on the loan.
		public decimal GetRemainingBalance()
		{
			//return AmountBorrowed;

			double monthlyInterestRate = ((double)InterestRate / 12) * 0.01;

			double currentBalance = (double)AmountBorrowed;
			//DateTime prevDate = DateBorrowed;
			int prevPaymentNumber = 0;

			foreach (Payment payment in Payments)
			{
				double interestAccrued = currentBalance * Math.Pow(monthlyInterestRate, payment.PaymentMonth - prevPaymentNumber);
				double principalPayment = (double)payment.PaymentAmount - interestAccrued;

				currentBalance = currentBalance + interestAccrued - (double)payment.PaymentAmount;
				prevPaymentNumber = payment.PaymentMonth;

			}
			return (decimal)currentBalance;
		}

		public decimal GetMinimumPayment()
		{
			double monthlyInterest = ((double)InterestRate / 12) * 0.01;
			int payments = GetRemainingPaymentPeriods();
			double balance = (double)GetRemainingBalance();

			double paymentAmount = balance /
				((Math.Pow(1 + monthlyInterest, payments) - 1) /
				(monthlyInterest * Math.Pow(1 + monthlyInterest, payments)));

			return (decimal)paymentAmount;
		}

		#endregion Calculated Fields

		#region Payment info -- Payments, PaymentHistory
		public List<Payment> Payments
        {
            get 
            {
                return DataAccess.GetPaymentsForLoan(Id);
            }
        }

        #endregion Payment Info

    }
}
