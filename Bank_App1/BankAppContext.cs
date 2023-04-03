using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App1
{
    public class BankAppContext: DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<TransferClass> TransferClass { get; set; }
        public DbSet<LoanClass> LoanClass { get; set; }
        public DbSet<DepositClass> DepositClasses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BankAppDb;Trusted_Connection=True;");
        }
    }
}
