using Microsoft.EntityFrameworkCore;
using SaleApi.Models;

namespace SaleApi.Data
{
    public class SaleDbContext : DbContext
    {
        public SaleDbContext(DbContextOptions<SaleDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<CashOrDebit> CashOrDebits { get; set; } = null!;


        public virtual DbSet<AccDebitCustomer> AccDebitCustomers { get; set; } = null!;


        public virtual DbSet<Customer> Customers { get; set; } = null!;

        public virtual DbSet<DebitInvoice> DebitInvoices { get; set; } = null!;

        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<PaymentReceived> PaymentReceiveds { get; set; } = null!;
        public virtual DbSet<ItemDetail> ItemDetails { get; set; } = null!;

        /*
         
        public virtual DbSet<JournalEntry> JournalEntries { get; set; } = null!;
         public virtual DbSet<AccountsFinancial> AccountsFinancials { get; set; } = null!;

           public virtual DbSet<FinAccType> FinAccTypes { get; set; } = null!;
     
        */


    }
}