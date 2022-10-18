using Micro.PurchaseApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Micro.PurchaseApi.Data
{
    public class PurchaseDbContext : DbContext
    {
        public PurchaseDbContext(DbContextOptions<PurchaseDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<CashOrDebit> CashOrDebits { get; set; } = null!;
      
        public virtual DbSet<AccDebitVendor> AccDebitVendors { get; set; } = null!;
    
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<BillItem> BillItems { get; set; } = null!;

        public virtual DbSet<DebitBill> DebitBills { get; set; } = null!;

        public virtual DbSet<PaymentsMade> PaymentsMades { get; set; } = null!;
     
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;
    }
}
