using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amortization_schedule_calculator.App_Data.AmortizationDBDataSetTableAdapters;
using amortization_schedule_calculator.Models;
using Dapper;

/*
 * Helpful Videos and Articles:
 * How to connect C# to SQL (the easy way) - IAmTimCorey
 * https://www.youtube.com/watch?v=Et2khGnrIqc
 * 
 * Par 1(C# sql database tutorial) - Sql Conneciton, Sql Connection String Builder (c# sql Server)
 * https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnectionstringbuilder?view=dotnet-plat-ext-7.0
 * (About 23 minutes in, it shows how to user the SqlConnectionStringBuilder class)
 * 
 * Dapper Project Page:
 * https://github.com/DapperLib/Dapper
 */
namespace amortization_schedule_calculator.HelperClasses
{
    public class DataAccess
    {
        private static string connString = Properties.Settings.Default.AmortizationDBConnectionString;
        
        public static List<Loan> GetAllLoans()
        {
            // Putting the code to access the database in a using statement makes
            // sure the connection is closed after the end of the using statement.
            try
            {
                using (IDbConnection connection = new SqlConnection(connString))
                {
                    // connection.Query() returns an IEnumerable type, have to convert that to a list.
                    return connection.Query<Loan>("SELECT * FROM Loans").ToList();
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static void AddNewLoan(string creditor, decimal amountBorrowed, 
            decimal interestRate, DateTime dateBorrowed,
            string description, int paymentPeriod)
        {
            // Put the data in an object
            var data = new
            {
                Creditor = creditor,
                AmountBorrowed = amountBorrowed,
                InterestRate = interestRate,
                DateBorrowed = dateBorrowed,
                Description = description,
                PaymentPeriod = paymentPeriod
            };
            string procedureString = "dbo.Loans_AddNewLoan " +
                "@Creditor, @AmountBorrowed, @InterestRate, @DateBorrowed, @Description, @PaymentPeriod";
            // Call the stored procedure
            using (IDbConnection connection = new SqlConnection(connString))
            {
                connection.Query<Loan>(procedureString, data);
            }
        }

        public static List<Loan> GetLoanByID(int id) 
        {
            using (IDbConnection connection = new SqlConnection(connString))
            {
                return connection.Query<Loan>("Loans_GetByID @LoanID", new { LoanID = id }).ToList();
            }
        }

		#region AddPayment overloads
		public static void AddPayment(int loanID, DateTime paymentDate, decimal paymentAmount)
        {
            // TODO: Implement ExistingPaymentException and throw it
            using (IDbConnection connection = new SqlConnection(connString))
            {
                var data = new
                {
                    LoanID = loanID,
                    PaymentDate = paymentDate,
                    PaymentAmount = paymentAmount
                };
                connection.Query<Payment>("Payments_AddPayment @LoanID, @PaymentDate, @PaymentAmount", data);
            }
        }

        public static void AddPayment(Payment payment)
        {
            using (IDbConnection connection = new SqlConnection(connString))
            {
                var data = new
                {
                    LoanID = payment.LoanID,
                    PaymentDate = payment.PaymentDate,
                    PaymentAmount = payment.PaymentAmount,
                    PaymentNumber = payment.PaymentMonth
                };
				connection.Query<Payment>("Payments_AddPayment @LoanID, @PaymentDate, @PaymentAmount, @PaymentNumber", data);
			}
        }
		#endregion

        public static void UpdatePayment(Payment payment)
        {
            using (IDbConnection connection = new SqlConnection(connString))
            {
                var data = new
                {
                    LoanID = payment.LoanID,
                    PaymentDate = payment.PaymentDate,
                    PaymentAmount = payment.PaymentAmount,
                    PaymentNumber = payment.PaymentMonth
                };
                connection.Query<Payment>("Payments_UpdatePayment @LoanID, @PaymentDate, @PaymentAmount, @PaymentNumber", data);
            }
        }

		public static List<Payment> GetPaymentsForLoan(int loanID)
        {
            using (IDbConnection connection = new SqlConnection(connString))
            {
                return connection.Query<Payment>("Payments_GetPaymentsByLoanID @LoanID", new { LoanID  = loanID }).ToList();
            }
        }

        public static List<Payment> GetPaymentByMonth(int loanID, int month)
        {
            using (IDbConnection connection = new SqlConnection(connString))
            {
                return connection.Query<Payment>("Payments_GetPaymentByNumber @LoanID, @Number", new { LoanID = loanID, Number = month }).ToList();
            }
        }
    }
}
