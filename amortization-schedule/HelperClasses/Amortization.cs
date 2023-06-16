using amortization_schedule_calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static amortization_schedule_calculator.Models.Loan;

namespace amortization_schedule_calculator.HelperClasses
{
	internal class Amortization
	{
		public static List<object> calculateAmortizationTable(Loan loan, bool showHistory)
		{
			return calculateAmortizationTable(loan, (double)loan.GetMinimumPayment(), showHistory);
		}

		public static List<object>calculateAmortizationTable(Loan loan, double monthlyPayment, bool showHistory)
		{
			if (monthlyPayment < (double)loan.GetMinimumPayment())
			{
				throw new ArgumentException();
			}

			double monthlyInterestRate = ((double)loan.InterestRate / 12) * 0.01;
			double currentBalance = (double)loan.AmountBorrowed;
			List<object> result = new List<object>();
			int prevPaymentNumber = 0;

			// Get the loan history if showHistory is true.
			if (showHistory)
			{
				foreach (Payment payment in loan.Payments)
				{
					double interestAccrued = currentBalance * Math.Pow(monthlyInterestRate, payment.PaymentMonth - prevPaymentNumber);
					double principalPayment = (double)payment.PaymentAmount - interestAccrued;

					currentBalance = currentBalance + interestAccrued - (double)payment.PaymentAmount;
					prevPaymentNumber = payment.PaymentMonth;

					var info = new
					{
						PaymentNumber = $"{payment.PaymentMonth}",
						PaymentAmount = $"{payment.PaymentAmount:C2}",
						InterestAccrued = $"{interestAccrued:C2}",
						PrincipalPayment = $"{principalPayment:C2}",
						Balance = $"{currentBalance:C2}"
					};
					result.Add(info);
				}
			}

			// Add the future amortization schedule to result.
			int currentPayment;
			int prevPayment;
			if (loan.Payments.Count == 0)
			{
				currentPayment = Math.Max(loan.GetCurrentPaymentNumber(), 1);
				prevPayment = 0;
			}
			else
			{
				if (loan.Payments[loan.Payments.Count - 1].PaymentMonth == loan.GetCurrentPaymentNumber())
				{
					currentPayment = loan.GetCurrentPaymentNumber() + 1;
					prevPayment = loan.GetCurrentPaymentNumber();
				}
				else
				{
					currentPayment = loan.GetCurrentPaymentNumber();
					prevPayment = loan.Payments[loan.Payments.Count - 1].PaymentMonth;
				}
			}

			// Calculate rows until the loan is paid off.
			double balance = (double)loan.GetRemainingBalance();
			
			while (balance > 0)
			{
				double interestAccrued = balance * Math.Pow(monthlyInterestRate, currentPayment - prevPayment);
				double principalPayment = monthlyPayment - interestAccrued;
				balance = balance + interestAccrued - monthlyPayment;
				if (balance < 0)
				{
					monthlyPayment = monthlyPayment + balance;
					balance = 0;
				}

				var info = new
				{
					PaymentNumber = $"{currentPayment}",
					PaymentAmount = $"{monthlyPayment:C2}",
					InterestAccrued = $"{interestAccrued:C2}",
					PrincipalPayment = $"{principalPayment:C2}",
					Balance = $"{balance:C2}"
				};
				result.Add(info);

				// Update all control variables.
				prevPayment = currentPayment;
				currentPayment++;
			}
			return result;
		}

		public static List<object> loanHistory(Loan loan)
		{
			double monthlyInterestRate = ((double)loan.InterestRate / 12) * 0.01;
			double currentBalance = (double)loan.AmountBorrowed;
			List<object> result = new List<object>();
			int prevPaymentNumber = 0;

			foreach(Payment payment in loan.Payments)
			{
				double interestAccrued = currentBalance * Math.Pow(monthlyInterestRate, payment.PaymentMonth - prevPaymentNumber);
				double principalPayment = (double)payment.PaymentAmount - interestAccrued;

				currentBalance = currentBalance + interestAccrued - (double)payment.PaymentAmount;
				prevPaymentNumber = payment.PaymentMonth;

				var info = new
				{
					PaymentNumber = $"{payment.PaymentMonth}",
					PaymentAmount = $"{payment.PaymentAmount:C2}",
					InterestAccrued = $"{interestAccrued:C2}",
					PrincipalPayment = $"{principalPayment:C2}",
					Balance = $"{currentBalance:C2}"
				};
				result.Add(info);
			}

			return result;
			//throw new NotImplementedException();
		}
	}
}
