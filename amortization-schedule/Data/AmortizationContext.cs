using amortization_schedule_calculator.Models;

using Microsoft.EntityFrameworkCore;

using System.Data.SqlClient;
using System.Configuration;

namespace amortization_schedule_calculator.Data
{
    internal class AmortizationContext : DbContext
    {

        public DbSet<Loan> Loans { get; set; } = null!;
        public DbSet<Payment> Payment { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|AmortizationDB.mdf;Integrated Security=True";
            //string conn = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\GitHub\\amortization - schedule\\amortization - schedule - calculator\\AmortizationDB.mdf; Integrated Security = True";
            string conn = Properties.Settings.Default.ConnectionString;

            //optionsBuilder.UseSqlServer(conn);
        }
    }
}
