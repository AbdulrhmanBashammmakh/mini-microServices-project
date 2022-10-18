using Microsoft.EntityFrameworkCore;

namespace Financial_Accounts.Data
{
    public class FinancialDbContext : DbContext
    {
        public FinancialDbContext(DbContextOptions<FinancialDbContext> options)
            : base(options)
        {

        }




        /*
         
        public virtual DbSet<LedgerEntry> LedgerEntries { get; set; } = null!;
         public virtual DbSet<AccountsFinancial> AccountsFinancials { get; set; } = null!;
                public virtual DbSet<JournalEntry> JournalEntries { get; set; } = null!;

           public virtual DbSet<FinAccType> FinAccTypes { get; set; } = null!;
     
        */
    }
}
